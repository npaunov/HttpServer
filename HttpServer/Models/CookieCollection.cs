using System;
using System.Collections;
using System.Collections.Generic;

namespace HttpServer.Models
{
    public class CookieCollection : IEnumerable<Cookie>
    {
        //Constructors
        public CookieCollection()
        {
            this.Cookies = new Dictionary<string, Cookie>();
        }

        //Public Properies
        public IDictionary<string, Cookie> Cookies { get; private set; }

        public int Count { get { return this.Cookies.Count; } }

        public Cookie this[string key]
        {
            get
            {
                return this.Cookies[key];
            }
            set
            {
                if (this.Cookies.ContainsKey(key))
                {
                    this.Cookies[key] = value;
                    return;
                }
                this.Cookies.Add(key, value);
            }
        }

        //Methods
        public bool Contains(string cookieName)
        {
            return this.Cookies.ContainsKey(cookieName);
        }

        public void Add(Cookie cookie)
        {
            if (!this.Cookies.ContainsKey(cookie.Name))
            {
                this.Cookies.Add(cookie.Name, new Cookie());
            }
            this.Cookies[cookie.Name] = cookie;
        }

        //Enumerators
        public IEnumerator<Cookie> GetEnumerator()
        {
            return this.Cookies.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join("; ", Cookies.Values);
        }
    }
}
