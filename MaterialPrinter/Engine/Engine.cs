using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Globalization;
using System.CodeDom.Compiler;
using System.Text;
using System.Reflection;
using Microsoft.CSharp;

using ccl;
using ccl.ShaderNodes;
using System.Drawing;

namespace MaterialPrinter
{
    public interface IUI
    {
        string getSceneFileName();
        string getMaterialFileName();
        string getOutputFolderName();
        void SetText(string text);
    }

    public class Engine
    {
        #region default surface mesh data
        static float[] vert_floats =
			{
				 1.0f, 1.0f, 0.0f, -1.0f, 1.0f, 0.0f, -1.0f, -1.0f, 0.0f, 1.0f, -1.0f, 0.0f
			};
        readonly static int[] nverts =
			{
				4
			};
        readonly static int[] vertex_indices =
			{
				0, 1, 2, 3
			};
        private static float[] UV_coords = 
            {
                1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.0f, 1.0f, 0.5f, 0.5f, 0.0f, 0.5f, 0.0f, 1.0f, 0.5f, 1.0f
            };
        #endregion
        private const uint width = 1024;
        private const uint height = 1024;
        private const uint samples = 1;


        static Session Session { get; set; }
        static Client Client { get; set; }
        static Device Device { get; set; }
        static Scene Scene { get; set; }

        private static bool b_init = false;

        public static bool Initialised
        {
            set
            {
                b_init = Initialised;
            }
            get
            {
                return b_init;
            }
        }

        static IUI _iui;
        public static IUI Iui
        {
            set { Engine._iui = value; }
        }

        public static void ShowMaterial()
        {
            /*
            SetMessage("Creating shader...");
            _iui.RefreshIUI();
            Shader test = Dynamic_Shader.Show(Client, Device, Scene, Shader.ShaderType.World);
            test.FinalizeGraph();
            Scene.DefaultSurface = test;
            Scene.Background.Shader = test;
            SetMessage("Shader \'"+test.Name+"\' Created!!!!");
             * */
        }

        public static bool CompileMaterial(String sourceName)
        {
            FileInfo sourceFile = new FileInfo(sourceName);
            CodeDomProvider provider = null;
            bool compileOk = false;

            SetMessage("Compiling material: " + sourceName);

            // Select the code provider based on the input file extension.
            if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
            {
                provider = CodeDomProvider.CreateProvider("CSharp");
            }
            else
            {
                Console.WriteLine("Source file must have a .cs or .vb extension");
            }

            if (provider != null)
            {

                // Format the executable file name.
                // Build the output assembly path using the current directory
                // and <source>_cs.exe or <source>_vb.exe.

                String exeName = String.Format(@"{0}\{1}.exe",
                    System.Environment.CurrentDirectory,
                    sourceFile.Name.Replace(".", "_"));

                CompilerParameters cp = new CompilerParameters();

                // Generate an executable instead of 
                // a class library.
                cp.GenerateExecutable = false;

                // Specify the assembly file name to generate.
                cp.OutputAssembly = exeName;

                // Save the assembly as a physical file.
                cp.GenerateInMemory = true;

                // Set whether to treat all warnings as errors.
                cp.TreatWarningsAsErrors = false;

                // Add the reference of csycles to the to-be-compiled material
                cp.ReferencedAssemblies.Add("csycles.dll");
                cp.ReferencedAssemblies.Add("System.dll");
                cp.ReferencedAssemblies.Add("System.Drawing.dll");

                // Invoke compilation of the source file.
                CompilerResults cr = provider.CompileAssemblyFromFile(cp, sourceName);

                if (cr.Errors.Count > 0)
                {
                    // Display compilation errors.
                    SetMessage("Errors building " + sourceName + "into " + cr.PathToAssembly);
                    //Console.WriteLine("Errors building {0} into {1}", sourceName, cr.PathToAssembly);
                    foreach (CompilerError ce in cr.Errors)
                    {
                        SetMessage("Error: " + ce.ToString());
                        //Console.WriteLine("  {0}", ce.ToString());
                        //Console.WriteLine();
                    }
                }
                else
                {
                    SetMessage("Source " + sourceName + "built into " + cr.PathToAssembly + " succesfully.");
                    // Display a successful compilation message.
                    //Console.WriteLine("Source {0} built into {1} successfully.", sourceName, cr.PathToAssembly);


                    var cls = cr.CompiledAssembly.GetType("HologramPrinter.Dynamic_Shader");
                    /*
                    var method = cls.GetMethod("CreateDynamicShader", BindingFlags.Static | BindingFlags.Public);   
                    var returned_value = method.Invoke(null, null);
                    returned_value = Activator.CreateInstance(Type.GetType("ccl.Shader"));
                    */

                    Object[] parameters;
                    parameters = new Object[4];
                    parameters[0] = Client;
                    parameters[1] = Device;
                    parameters[2] = Scene;
                    parameters[3] = Shader.ShaderType.Material;

                    MethodInfo methodInformation = cls.GetMethod("Show");
                    //object assemblyInstance = cr.CompiledAssembly.CreateInstance("Test Shader", false);
                    var returned_value = methodInformation.Invoke(null, parameters);
                    SetMessage("Background shader loaded from material file");

                    //returned_value = Activator.CreateInstance(Type.GetType("ccl.Shader"));

                    if (returned_value is Shader)
                    {
                        SetMessage("Material loaded into scene!");
                        Shader dynamic_shader = returned_value as Shader;
                        Scene.AddShader(dynamic_shader);
                        Scene.DefaultSurface = dynamic_shader;
                    }
                    else
                    {
                        SetMessage("Unable to load Material into scene!");
                    }


                    /*
                    try
                    {
                        Shader dynamic_shader = (Shader)Convert.ChangeType(returned_value, typeof(Shader));
                        Scene.AddShader(dynamic_shader);
                        Scene.Background.Shader = dynamic_shader;
                    }
                    catch (InvalidCastException)
                    {
                        Console.WriteLine("Cannot convert an object to a Shader");
                    }
                     * */

                    /*
                    //Shader dynamic_shader = (Shader)returned_value;
                    Scene.Background.AoDistance = 0.0f;
                    Scene.Background.AoFactor = 0.0f;
                    Scene.Background.Visibility = PathRay.PATH_RAY_ALL_VISIBILITY;
                    */

                    //String ClassName = "ccl.Shader";
                    //Shader dynamic_shader = (Shader)Activator.CreateInstance(cr.CompiledAssembly, ClassName))

                }

                // Return the results of the compilation.
                if (cr.Errors.Count > 0)
                {
                    compileOk = false;
                }
                else
                {
                    compileOk = true;
                }
            }
            return compileOk;
        }

        static public void StatusUpdateCallback(uint sessionId)
        {
            float progress;
            double total_time;

            CSycles.progress_get_progress(Client.Id, sessionId, out progress, out total_time);
            var status = CSycles.progress_get_status(Client.Id, sessionId);
            var substatus = CSycles.progress_get_substatus(Client.Id, sessionId);
            uint samples;
            uint num_samples;

            CSycles.tilemanager_get_sample_info(Client.Id, sessionId, out samples, out num_samples);

            if (status.Equals("Finished"))
            {
                Console.WriteLine("wohoo... :D");
            }

            status = "[" + status + "]";
            if (!substatus.Equals(string.Empty)) status = status + ": " + substatus;
            Console.WriteLine("C# status update: {0} {1} {2} {3} <|> {4:N}s {5:P}", CSycles.progress_get_sample(Client.Id, sessionId), status, samples, num_samples, total_time, progress);
        }

        static public void WriteRenderTileCallback(uint sessionId, uint x, uint y, uint w, uint h, uint depth)
        {
            Console.WriteLine("C# Write Render Tile for session {0} at ({1},{2}) [{3}]", sessionId, x, y, depth);
        }

        public static void UpdateRenderTileCallback(uint sessionId, uint x, uint y, uint w, uint h, uint depth)
        {
            Console.WriteLine("C# Update Render Tile for session {0} at ({1},{2}) [{3}]", sessionId, x, y, depth);
        }

        /// <summary>
        /// Callback for debug logging facility. Will be called only for Debug builds of ccycles.dll
        /// </summary>
        /// <param name="msg"></param>
        public static void LoggerCallback(string msg)
        {
            Console.WriteLine("DBG: {0}", msg);
        }

        public static int ColorClamp(int ch)
        {
            if (ch < 0) return 0;
            return ch > 255 ? 255 : ch;
        }

        public static float DegToRad(float ang)
        {
            return ang * (float)Math.PI / 180.0f;
        }

        private static CSycles.UpdateCallback g_update_callback;
        private static CSycles.RenderTileCallback g_update_render_tile_callback;
        private static CSycles.RenderTileCallback g_write_render_tile_callback;

        private static CSycles.LoggerCallback g_logger_callback;

        public static void SetMessage(string msg)
        {
            _iui.SetText(msg);
        }

        public static void Initiate()
        {
            SetMessage("Reading input...");

            string materialFile = _iui.getMaterialFileName();//Path.GetFullPath(_iui.getMaterialFileName());
            string sceneFile = _iui.getSceneFileName();//Path.GetFullPath(_iui.getSceneFileName());

            CSycles.set_kernel_path("lib");
            CSycles.initialise();

            SetMessage("Initialising callbacks...");

            g_update_callback = StatusUpdateCallback;
            g_update_render_tile_callback = UpdateRenderTileCallback;
            g_write_render_tile_callback = WriteRenderTileCallback;
            g_logger_callback = LoggerCallback;

            SetMessage("Initialising client...");

            var client = new Client();
            Client = client;
            CSycles.set_logger(client.Id, g_logger_callback);


            SetMessage("Available devices-> Device 0: " + Device.GetDevice(0).Name + ", Device 1: " + Device.GetDevice(1).Name + ", Device 2: " + Device.GetDevice(2).Name + ", Cuda available: " + Device.CudaAvailable() + ", Cuda device: " + Device.FirstCuda.Name);


            SetMessage("Selecting devices...");
            var dev = Device.FirstCuda;
            Device = dev;

            SetMessage("Using device " + dev.Name);

            SetMessage("Creating default scene...");

            #region Create default scene

            var scene_params = new SceneParameters(client, ShadingSystem.SVM, BvhType.Static, true, false, false, false);
            var scene = new Scene(client, scene_params, dev);

            SetMessage("Setup Camera...");
            /* move the scene camera a bit, so we can see our render result. */
            
            var t = Transform.Identity();
            //float angle = 90.0f;
            //t = t * Transform.Rotate(angle * (float)Math.PI / 180.0f, new float4(0.0f, 1.0f, 0.0f));
            t = t * Transform.Translate(0.0f, 0.0f, 5.0f);
            t = t * Transform.Scale(1.0f, -1.0f, -1.0f);
            
            scene.Camera.Matrix = t;
            /* set also the camera size = render resolution in pixels. Also do some extra settings. */
            scene.Camera.Size = new Size((int)Engine.width, (int)Engine.height);
            scene.Camera.Type = CameraType.Orthographic;
            scene.Camera.ApertureSize = 0.0f;
            scene.Camera.Fov = 0.661f;
            scene.Camera.FocalDistance = 0.0f;
            scene.Camera.SensorWidth = 32.0f;
            scene.Camera.SensorHeight = 18.0f;
            #endregion

            SetMessage("Creating default shader...");

            #region default shader            

            SetMessage("Creating shader...");
            Shader test = TestShader.ReadShader(Client, Device, scene, Shader.ShaderType.Material);
            scene.DefaultSurface = test;

            SetMessage("Shader \'" + test.Name + "\' Created!!!!");
            SetMessage("" + test.Type.ToString());

            SetMessage("Creating background shader...");

            #endregion

            #region background shader
            /* Create a simple surface shader and make it the default surface shader */
            var background = new Shader(Client, Shader.ShaderType.World)
            {
                Name = "Background material"
            };

            var bgnode = new BackgroundNode();
            bgnode.ins.Color.Value = new float4(1.0f, 0.64f, 0.0f); //255-165-0
            //bgnode.ins.Strength.Value = 2.0f;

            background.AddNode(bgnode);
            bgnode.outs.Background.Connect(background.Output.ins.Surface);

            background.FinalizeGraph();

            scene.AddShader(background);
            scene.Background.Shader = background;
            scene.Background.Visibility = PathRay.AllVisibility;
            #endregion

            /* get scene-specific default shader ID */
            var default_shader = scene.ShaderSceneId(scene.DefaultSurface);

            SetMessage("Set integrator settings...");
            /* Set integrator settings */
            scene.Integrator.IntegratorMethod = IntegratorMethod.Path;
            scene.Integrator.MaxBounce = 1;
            scene.Integrator.MinBounce = 1;
            scene.Integrator.NoCaustics = true;
            scene.Integrator.MaxDiffuseBounce = 1;
            scene.Integrator.MaxGlossyBounce = 1;
            scene.Integrator.Seed = 1;
            scene.Integrator.SamplingPattern = SamplingPattern.Sobol;
            scene.Integrator.FilterGlossy = 0.0f;

            SetMessage("Add geometry to scene...");
            /* Add a bit of geometry and move camera around so we can see what we're rendering.
             * First off we need an object, we put it at the origo
             */
            if(!sceneFile.Equals(string.Empty))
            {
                var xml = new XmlReader(client, sceneFile);
                xml.Parse();
                var width = (uint)scene.Camera.Size.Width;
                var height = (uint)scene.Camera.Size.Height;
            }
            else
            {
                var fc = Engine.nverts.Aggregate(0, (total, next) =>
                                                                            next == 4 ? total + 2 : total + 1);
                float[] uvs = new float[fc * 3 * 2];
                var uvoffs = 0;

                // OLD
                var ob = CSycles.scene_add_object(Client.Id, scene.Id);
                CSycles.object_set_matrix(Client.Id, scene.Id, ob, Transform.Identity());
                var mesh = CSycles.scene_add_mesh(Client.Id, scene.Id, ob, default_shader);

                /* populate mesh with geometry */
                
                CSycles.mesh_set_verts(Client.Id, scene.Id, mesh, ref vert_floats, (uint)(vert_floats.Length / 3));
                var index_offset = 0;
                foreach (var face in nverts)
                {
                    for (var j = 0; j < face - 2; j++)
                    {
                        var v0 = (uint)vertex_indices[index_offset];
                        var v1 = (uint)vertex_indices[index_offset + j + 1];
                        var v2 = (uint)vertex_indices[index_offset + j + 2];

                        uvs[uvoffs] = UV_coords[index_offset * 2];
                        uvs[uvoffs + 1] = UV_coords[index_offset * 2 + 1];
                        uvs[uvoffs + 2] = UV_coords[(index_offset + j + 1) * 2];
                        uvs[uvoffs + 3] = UV_coords[(index_offset + j + 1) * 2 + 1];
                        uvs[uvoffs + 4] = UV_coords[(index_offset + j + 2) * 2];
                        uvs[uvoffs + 5] = UV_coords[(index_offset + j + 2) * 2 + 1];

                        uvoffs += 6;

                        CSycles.mesh_add_triangle(Client.Id, scene.Id, mesh, v0, v1, v2, default_shader, false);
                    }

                    index_offset += face;
                }

                CSycles.mesh_set_uvs(Client.Id, scene.Id, mesh, ref uvs, (uint)(uvs.Length / 2));

            }         


            


            #region point light shader

            //var light_shader = new Shader(client, Shader.ShaderType.Material)
            //{
            //    Name = "Tester light shader"
            //};

            //var emission_node = new EmissionNode();
            //emission_node.ins.Color.Value = new float4(0.8f);
            //emission_node.ins.Strength.Value = 30.0f;

            //light_shader.AddNode(emission_node);
            //emission_node.outs.Emission.Connect(light_shader.Output.ins.Surface);
            //light_shader.FinalizeGraph();
            //scene.AddShader(light_shader);
            #endregion


            Scene = scene;

            CSycles.shutdown();

            Initialised = true;

            //CSycles.shutdown();

            /*

            #region background shader
            var background_shader = new Shader(client, Shader.ShaderType.World)
            {
                Name = "Background shader"
            };

            var bgnode = new BackgroundNode();
            bgnode.ins.Color.Value = new float4(0.0f);
            bgnode.ins.Strength.Value = 1.0f;

            background_shader.AddNode(bgnode);
            bgnode.outs.Background.Connect(background_shader.Output.ins.Surface);
            background_shader.FinalizeGraph();

            scene.AddShader(background_shader);

            scene.Background.Shader = background_shader;
            scene.Background.AoDistance = 0.0f;
            scene.Background.AoFactor = 0.0f;
            scene.Background.Visibility = PathRay.PATH_RAY_ALL_VISIBILITY;
            #endregion
            #region diffuse shader

            var diffuse_shader = create_some_setup_shader();
            scene.AddShader(diffuse_shader);
            scene.DefaultSurface = diffuse_shader;
            #endregion

			

            var xml = new XmlReader(client, sceneFile);
            xml.Parse();
            var width = (uint)scene.Camera.Size.Width;
            var height = (uint)scene.Camera.Size.Height;
            */

            /* move the scene camera a bit, so we can see our render result. */
            /*
            var t = Transform.Identity();
            t = t * Transform.Rotate(75.0f * (float)Math.PI / 180.0f, new float4(0.0f, 1.0f, 1.0f));
			
            t = t * Transform.Translate(50.0f, 2.0f * (float)tile, -10f);//2.0f * (float)tile
            //scene.Camera.Matrix.x = new float4((float)(2.0f * (float)tile), (float)0.0f, (float)0.0f);

             * */

            /*
            var transform = Transform.Identity();
            //rotate
            var angle = DegToRad(75.0f);
            var axis = new float4(0.0f, 1.0f, 1.0f);
            transform = transform * ccl.Transform.Rotate(angle, axis);
            //translate
            float tr = 2.0f * (float)tile;
            _iui.SetText("Moving camera: " + tr);
            transform = transform * ccl.Transform.Translate(0.000f, -2.302f+ tr, 0.617f);
            scene.Camera.Matrix = transform;
            */

        }

        public static void Render(int tile)
        {
            CSycles.set_kernel_path("lib");
            CSycles.initialise();

            /*
            g_update_callback = StatusUpdateCallback;
            g_update_render_tile_callback = UpdateRenderTileCallback;
            g_write_render_tile_callback = WriteRenderTileCallback;
            g_logger_callback = LoggerCallback;
             * */

            string outFolder = _iui.getOutputFolderName();//Path.GetFullPath(_iui.getOutputFolderName());

            _iui.SetText("Setting up session parameters...");

            var session_params = new SessionParameters(Client, Device)
            {
                Experimental = false,
                Samples = (int)samples,
                TileSize = new Size(64, 64),
                StartResolution = 64,
                Threads = 1,
                ShadingSystem = ShadingSystem.SVM,
                Background = true,
                ProgressiveRefine = false
            };
            Session = new Session(Client, session_params, Scene);
            Session.Reset(width, height, samples);

            Session.UpdateCallback = g_update_callback;
            Session.UpdateTileCallback = g_update_render_tile_callback;
            Session.WriteTileCallback = g_write_render_tile_callback;


            _iui.SetText("Rendering tile " + tile + ": " + CSycles.progress_get_status(Client.Id, Session.Id));

            //_iui.SetText("Devices: " + Device.GetDevice(2).Name);
            //_iui.SetText("Device 0: " + Device.GetDevice(0).Name + ", Device 1: " + Device.GetDevice(1).Name + ", Device 2: " + Device.GetDevice(2).Name + ", Cuda available: " + Device.CudaAvailable() + ", Cuda device: " + Device.FirstCuda.Name);

            Session.Start();
            Session.Wait();

            uint bufsize;
            uint bufstride;
            CSycles.session_get_buffer_info(Client.Id, Session.Id, out bufsize, out bufstride);
            var pixels = CSycles.session_copy_buffer(Client.Id, Session.Id, bufsize);

            _iui.SetText("Creating bitmap...");

            var bmp = new Bitmap((int)width, (int)height);
            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    var i = y * (int)width * 4 + x * 4;
                    var r = ColorClamp((int)(pixels[i] * 255.0f));
                    var g = ColorClamp((int)(pixels[i + 1] * 255.0f));
                    var b = ColorClamp((int)(pixels[i + 2] * 255.0f));
                    var a = ColorClamp((int)(pixels[i + 3] * 255.0f));
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            _iui.SetText("Saving bitmap...");

            if (string.IsNullOrEmpty(outFolder))
                bmp.Save("test" + tile + ".bmp");
            else
                bmp.Save(outFolder + "\\test" + tile + ".bmp");

            _iui.SetText("Done");

            CSycles.shutdown();
        }
    }
}
