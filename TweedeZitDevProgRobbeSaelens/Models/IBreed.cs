using System;
using System.Collections.Generic;
using System.Text;

namespace TweedeZitDevProgRobbeSaelens.Models
{
    public interface IBreed
    {
        string Id { get; set; }

        string Name { get; set; }

        void PrintSendInstructions();
    }
}
