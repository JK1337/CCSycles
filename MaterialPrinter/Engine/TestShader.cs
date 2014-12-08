using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ccl;
using ccl.ShaderNodes;
using System.Drawing;

namespace MaterialPrinter
{
    public static class TestShader
    {
        private static Client client;
        private static Device device;
        private static Scene scene;

        public static Client Client
        {
            set
            {
                client = Client;
            }
            get
            {
                return client;
            }
        }

        public static Device Device
        {
            set
            {
                device = Device;
            }
            get
            {
                return device;
            }
        }

        public static Scene Scene
        {
            set
            {
                scene = Scene;
            }
            get
            {
                return scene;
            }
        }

        public static Shader ReadShader(Client cl, Device dv, Scene sc, Shader.ShaderType st)
        {
            Client = cl;
            Device = dv;
            Scene = sc;

            #region material_hologramu
            var material_hologramu = new Shader(cl, st);

            material_hologramu.Name = "material_hologramu";
            material_hologramu.UseMis = false;
            material_hologramu.UseTransparentShadow = true;
            material_hologramu.HeterogeneousVolume = false;


            var hologram_material_emission = new EmissionNode();
            hologram_material_emission.ins.Strength.Value = 1.000f;

            var image_texture = new ImageTextureNode();
            image_texture.ColorSpace = TextureNode.TextureColorSpace.None;
            image_texture.Projection = TextureNode.TextureProjection.Flat;
            image_texture.Interpolation = InterpolationType.Linear;
            image_texture.Filename = "D:\\Material\\tifs\\TST5.tif";
            using (var bmp = new Bitmap(image_texture.Filename))
            {
                var l = bmp.Width * bmp.Height * 4;
                var bmpdata = new byte[l];
                for (var x = 0; x < bmp.Width; x++)
                {
                    for (var y = 0; y < bmp.Height; y++)
                    {
                        var pos = y * bmp.Width * 4 + x * 4;
                        var pixel = bmp.GetPixel(x, y);
                        bmpdata[pos] = pixel.R;
                        bmpdata[pos + 1] = pixel.G;
                        bmpdata[pos + 2] = pixel.B;
                        bmpdata[pos + 3] = pixel.A;
                    }
                }
                image_texture.ByteImage = bmpdata;
                image_texture.Width = (uint)bmp.Width;
                image_texture.Height = (uint)bmp.Height;
            }

            var input = new TextureCoordinateNode();

            var mapping_001 = new MappingNode();
            mapping_001.vector_type = MappingNode.vector_types.TEXTURE;
            mapping_001.Translation = new float4(1.000f, 1.000f, 1.000f);
            mapping_001.Rotation = new float4(0.000f, 0.000f, 0.000f);
            mapping_001.Scale = new float4(1.000f, 1.000f, 1.000f);

            material_hologramu.AddNode(hologram_material_emission);
            material_hologramu.AddNode(image_texture);
            material_hologramu.AddNode(input);
            material_hologramu.AddNode(mapping_001);

            image_texture.outs.Color.Connect(hologram_material_emission.ins.Color);
            input.outs.UV.Connect(mapping_001.ins.Vector);
            mapping_001.outs.Vector.Connect(image_texture.ins.Vector);
            hologram_material_emission.outs.Emission.Connect(material_hologramu.Output.ins.Surface);

            material_hologramu.FinalizeGraph();

            sc.AddShader(material_hologramu);
            //sc.Background.Shader = material_hologramu;
            //sc.DefaultSurface = material_hologramu;

            return material_hologramu;
            #endregion
        }
    }

}
