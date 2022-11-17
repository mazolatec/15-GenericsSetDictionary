﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GetHashCodeEquals.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client client = (Client)obj;
            return Email.Equals(client.Email);

        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
