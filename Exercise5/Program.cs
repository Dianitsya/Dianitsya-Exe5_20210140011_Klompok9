﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
	public class QNode
	{
		public int data;
		public QNode next;
		public QNode(int value)
		{
			this.data = value;
			this.next = null;
		}
	}
	