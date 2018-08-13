using System;
using System.Collections.Generic;
using System.Text;

namespace dictionary_states_capitals
{
    public class State
    {
        public string Capital { get; set; }//state capital
        public int Population { get; set; }//in millions
        public int Size { get; set; }//size in square miles


        //constructor
        public State(string capital, int population, int size)
        {
            Capital = capital;
            Population = population;
            Size = size;
        }

        public static Dictionary<string,State> GetStates()
        {
            var states = new Dictionary<string, State>();
            var theState = new State("Montgomery", 12345, 123);
            states.Add("Alabama", theState);
            theState = new State("juneau", 6789, 456);
            states.Add("Alaska", theState);
            return states;
        }
    }
}
