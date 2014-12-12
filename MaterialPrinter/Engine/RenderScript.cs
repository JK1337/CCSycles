﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialPrinter
{
    class RenderScript
    {
        public RenderScript() { }
        private bool _TestRender;
        private int _OrthoScale;
        private int _NumberOfHorizontalSteps;
        private int _NumberOfVerticalSteps;
        private int _TestStepX;
        private int _TestStepY;
        private int _CurrentX;
        private int _CurrentY;

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
        public int CurrentX
        {
            get
            {
                return _CurrentX;
            }
            set
            {
                _CurrentX = value;
            }
        }
        public int CurrentY
        {
            get
            {
                return _CurrentY;
            }
            set
            {
                _CurrentY = value;
            }
        }
    }
}
