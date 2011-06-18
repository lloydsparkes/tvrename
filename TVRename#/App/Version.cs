// 
// Main website for TVRename is http://tvrename.com
// 
// Source code available at http://code.google.com/p/tvrename/
// 
// This code is released under GPLv3 http://www.gnu.org/licenses/gpl.html
// 
namespace TVRename
{
    // What version are we?
    // Are we running under Mono, rather than MS.NET ?
    public static class Version
    {
        private static bool? OnMonoCached;

        public static bool OnMono()
        {
            if (!OnMonoCached.HasValue)
                OnMonoCached = System.Type.GetType("Mono.Runtime") != null;
            return OnMonoCached.Value;
        }

        public static string DisplayVersionString()
        {
            // all versions while developing are marked (dev)
            // only remove for final release build for upload
            // to site.

            // Release history:
            // Version 2.2.0b7 released 20 January 2011, r143
            // Version 2.2.0b6 unofficial release 2010
            // Version 2.2.0b5 released 2 May 2010, r133
            // Version 2.2.0b4 released 26 April 2010, r128
            // Version 2.2.0b3 released 16 April 2010, r110
            // Version 2.2.0b2 released 14 April 2010, r108
            // Version 2.2.0b1 released 9 April 2010, r94

            string v = "2.2.0b8 (dev)";
#if DEBUG
            return v + " ** Debug Build **";
#else
            return v;
#endif
        }
    }
}