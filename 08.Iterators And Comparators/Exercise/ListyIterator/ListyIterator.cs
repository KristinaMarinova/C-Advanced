﻿using System;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        private int index;

        public ListyIterator(List<T> collection)
        {
            this.elements = collection;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return this.index < this.elements.Count - 1;
        }

        public void Print()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.elements[this.index]);
        }
    }
}
