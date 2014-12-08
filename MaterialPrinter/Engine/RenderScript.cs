using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using Microsoft.CSharp;

using ccl;
using ccl.ShaderNodes;
using System.Drawing;
using System.Diagnostics;


namespace MaterialPrinter
{
    class RenderScript
    {
        private bool _TestRender;
        private int _ResolutionX;
        private int _ResolutionY;
        private int _NumberOfHorizontalSteps;
        private int _NumberOffVerticalSteps;
        private int _TestStepX;
        private int _TestStepY;
        private int _CurrentTile;

        public bool TestRender
        {
            get
            {
                return _TestRender;
            }
            set
            {
                _TestRender = value;
            }
        }
        public int ResolutionX
        {
            get
            {
                return _ResolutionX;
            }
            set
            {
                _ResolutionX = value;
            }
        }
        public int ResolutionY
        {
            get
            {
                return _ResolutionY;
            }
            set
            {
                _ResolutionY = value;
            }
        }
        public int NumberOfHorizontalSteps
        {
            get
            {
                return _NumberOfHorizontalSteps;
            }
            set
            {
                _NumberOfHorizontalSteps = value;
            }
        }
        public int NumberOffVerticalSteps
        {
            get
            {
                return _NumberOffVerticalSteps;
            }
            set
            {
                _NumberOffVerticalSteps = value;
            }
        }
        public int TestStepX
        {
            get
            {
                return _TestStepX;
            }
            set
            {
                _TestStepX = value;
            }
        }
        public int TestStepY
        {
            get
            {
                return _TestStepY;
            }
            set
            {
                _TestStepY = value;
            }
        }
        public int CurrentTile
        {
            get
            {
                return _CurrentTile;
            }
            set
            {
                _CurrentTile = value;
            }
        }

        public RenderScript()
        {
            // initiate values
        }

        public void Execute()
        {
            try
            {
                // TestRender: Only render test tile

                // Not a Testrender: Render loop
                // Start Stopwatch Render
                // Init Camera Start position
                // Renderloop Horizontal
                // Renderloop Vertical
                // Start Stopwatch Tile
                // Increment Camera position
                // Save render
                // End Stopwatch Tile
                // Do garbage collection
                // Report Time

            }
            catch
            {
                Engine.SetMessage("Error on Renderscript execution");
            }
        }        

        static void Profile(string description, int iterations, Action func) {
            // warm up 
            func();

            var watch = new Stopwatch(); 

            // clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            watch.Start();
            for (int i = 0; i < iterations; i++) {
                func();
            }
            watch.Stop();
            Console.Write(description);
            Console.WriteLine(" Time Elapsed {0} ms", watch.Elapsed.TotalMilliseconds);
        }

        static void ProfileGarbageMany(string description, int iterations, Action func) {
            // warm up 
            func();

            var watch = new Stopwatch(); 

            // clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            watch.Start();
            for (int i = 0; i < iterations; i++) {
                func();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            watch.Stop();
            Console.Write(description);
            Console.WriteLine(" Time Elapsed {0} ms", watch.Elapsed.TotalMilliseconds);
        }

        static void ProfileGarbage(string description, int iterations, Action func) {
            // warm up 
            func();

            var watch = new Stopwatch(); 

            // clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            watch.Start();
            for (int i = 0; i < iterations; i++) {
                func();

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            watch.Stop();
            Console.Write(description);
            Console.WriteLine(" Time Elapsed {0} ms", watch.Elapsed.TotalMilliseconds);
        }

    }
}
