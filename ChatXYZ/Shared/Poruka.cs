﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChatXYZ.Shared
{
	public class Poruka
	{
		public Korisnik Posiljaoc { get; set; }
		public DateTime Vreme { get; set; }
		public string Sadrzaj { get; set; }
	}
}
