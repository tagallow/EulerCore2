using System;
using System.Collections.Generic;
using System.Linq;

/* 
    https://projecteuler.net/problem=1  */


namespace EulerCore2
{
    static class MagnetParse
    {
        public static void Solve()
        {
            //https://en.wikipedia.org/wiki/Magnet_URI_scheme#Format
            string magnetURI = "magnet:?xt=urn:btih:ec7a402ff515d80f30f6244847b672ae9fbe5d7a&dn=2021-01-11-raspios-buster-armhf-lite.zip&tr=http%3a%2f%2ftracker.raspberrypi.org%3a6969%2fannounce";

            string prefix = "magnet:?xt=urn:btih:";
            string hash = "ec7a402ff515d80f30f6244847b672ae9fbe5d7a";
            string name = "2021-01-11-raspios-buster-armhf-lite.zip";


            MagnetURI uri = new MagnetURI(hash, name);

            Console.WriteLine("Solution: {0}", uri.ToString());
        }
    }
    public class MagnetURI{
        public MagnetURI(): this(string.Empty, string.Empty) {}
        public MagnetURI(string hash) : this(hash,string.Empty){}
        public MagnetURI(string hash, string name){
            this.hash = hash;
            this.name = name;
            trackers = new List<string>();
        }
        public override string ToString(){
            string uri = string.Format(prefix + hash + _dn + "{0}", name);
            foreach(string tr in trackers){
                uri += _tr + tr;
            }
            return uri;
        }
        public string hash{ get; set; }
        public string name { get; set; }
        private List<string> trackers { get; set; }
        public void addTracker(string tracker){
            trackers.Add(tracker);
        }

        private readonly string prefix = "magnet:?xt=urn:btih:";
        private readonly string _dn = "&dn=";
        private readonly string _tr = "&tr=";
    }
}