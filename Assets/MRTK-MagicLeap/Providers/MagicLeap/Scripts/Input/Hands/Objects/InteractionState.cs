/// -------------------------------------------------------------------------------
// MRTK - MagicLeap
// https://github.com/magicleap/MRTK-MagicLeap
// -------------------------------------------------------------------------------
//
// MIT License
//
// Copyright(c) 2021 Magic Leap, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//
// -------------------------------------------------------------------------------
//

using System;

namespace MagicLeap.MRTK.DeviceManagement.Input.Hands
{
    public class InteractionState
    {
        //Events:
        public event Action OnBegin;
        public event Action OnEnd;
        public event Action OnUpdate;

        //Public Properties:
        public bool Active
        {
            get;
            private set;
        }

        //Private Variables:
        private InteractionPoint _interactionPoint;

        //Constructors:
        public InteractionState(InteractionPoint interactionPoint)
        {
            _interactionPoint = interactionPoint;
        }

        //Public Methods:
        public void FireBegin()
        {
            Active = true;
            OnBegin?.Invoke();
        }

        public void FireEnd()
        {
            Active = false;
            OnEnd?.Invoke();
        }

        public void FireUpdate()
        {
            OnUpdate?.Invoke();
        }
    }
}