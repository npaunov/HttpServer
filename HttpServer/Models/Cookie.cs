﻿namespace HttpServer.Models
{
    public class Cookie
    {
        public Cookie() : this(null, null)
        {
        }

        public Cookie(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }
        public string Value { get; private set; }

        public override string ToString()
        {
            return $"{this.Name}={this.Value}";
        }
    }

}
