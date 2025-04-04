﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing.Models
{
	public class SelectedImage
	{
        public Guid Id { get; set; }
		public string URL { get; set; }

        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public virtual Color Color { get; set; }
    }
}
