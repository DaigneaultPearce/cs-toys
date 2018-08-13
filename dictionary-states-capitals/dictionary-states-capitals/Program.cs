using System;
using System.Collections.Generic;

namespace dictionary_states_capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> d_state_cap = new Dictionary<string, string>();
            //Console.WriteLine("Welcome to my collection of states and capitals");
            //d_state_cap.Add("Alabama", "Montgomery");
            //d_state_cap.Add("Alasky", "Juneau");
            //d_state_cap.Add("Arizona", "Phoenix");
            //d_state_cap.Add("Massachusetts", "Boston");
            //d_state_cap.Add("Wyoming", "Cheyenne");

            var states = State.GetStates();
            var theState = states["Alaska"];
            Console.WriteLine("Capital of Alaska is {0}, population {1}, size {2} square miles", theState.Capital, theState.Population, theState.Size);
        }

    }
}
