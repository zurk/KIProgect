using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SoundProcessing
{

    public class BTreeNode<T>
    {
        public T Value;
        public BTreeNode<T> L;
        public BTreeNode<T> R;

        public BTreeNode()
        {}
        
    }
}

