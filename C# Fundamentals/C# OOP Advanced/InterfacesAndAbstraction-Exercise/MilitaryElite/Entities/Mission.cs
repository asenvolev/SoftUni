﻿namespace MilitaryElite
{
    public class Mission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; private set; }
        public string State { get; private set; }
        public void CompleteMission()
        {
            this.State = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}