using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialPrinter
{
    class RenderJob
    {
        public RenderJob() { }
        private bool _TestRender;
        private int _OrthoScale;
        private int _NumberOfHorizontalSteps;
        private int _NumberOfVerticalSteps;
        private int _TestStepX;
        private int _TestStepY;
        private int _StartX;
        private int _StartY;
        private int _EndX;
        private int _EndY;

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
        public int OrthoScale
        {
            get
            {
                return _OrthoScale;
            }
            set
            {
                _OrthoScale = value;
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
        public int NumberOfVerticalSteps
        {
            get
            {
                return _NumberOfVerticalSteps;
            }
            set
            {
                _NumberOfVerticalSteps = value;
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
        public int StartX
        {
            get
            {
                return _StartX;
            }
            set
            {
                _StartX = value;
            }
        }
        public int StartY
        {
            get
            {
                return _StartY;
            }
            set
            {
                _StartY = value;
            }
        }
        public int EndX
        {
            get
            {
                return _EndX;
            }
            set
            {
                _EndX = value;
            }
        }
        public int EndY
        {
            get
            {
                return _EndY;
            }
            set
            {
                _EndY = value;
            }
        }
    }
}
