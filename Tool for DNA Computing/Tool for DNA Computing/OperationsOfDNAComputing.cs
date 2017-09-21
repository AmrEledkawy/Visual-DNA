using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tool_for_DNA_Computing
{
    class OperationsOfDNAComputing
    {

        #region DNA_Analysis
        public static float[] Nu_Percentage(string Seq)
        {
            /*this code calculates the percentage of every nucleotide(a,c,t or g)
              by calculate the total number of every necleotide and 
              then divides it on the length of the sequence to then send it to 
              the nucleotides form and then to the diagram and also it send 
              the report number (project)
            */

            int gn = 0;
            int cn = 0;
            int tn = 0;
            int an = 0;
           
            G_C_A_T_Content(Seq, out an, out cn, out gn, out tn);
            float total = an + tn + gn + cn;

            float apr = an / total * 100;
            float tpr = tn / total * 100;
            float gpr = gn / total * 100;
            float cpr = cn / total * 100;
            float[] Nu_No = new float[4];

            Nu_No[0] = apr;
            Nu_No[1] = cpr;
            Nu_No[2] = gpr;
            Nu_No[3] = tpr;

            return (float[])Nu_No;
        }
        public static int DNA_Melting_Temp(string Sequence)
        {
            int GC_Content;
            int AT_Content;
            GC_AT_Content(Sequence, out GC_Content, out AT_Content);
            int Melt = 4 * GC_Content + 2 * AT_Content;
            return Melt;
        }
        public static double DNA_MW(string Seq)
        {
            int a = 0;
            int c = 0;
            int g = 0;
            int t = 0;
            G_C_A_T_Content(Seq, out a, out c, out g, out t);
            double MW = 329.2 * g + 313.2 * a + 304.2 * t + 289.2 * c;
            return MW;
        }
        public static void GC_AT_Content(string Seq, out int GC_Content, out int AT_Content)
        {
            int gc = 0;
            int at = 0;
            for (int s = 0; s < Seq.Length; s++)
            {
                if (Seq[s] == 'C' || Seq[s] == 'G')
                    gc++;
                if (Seq[s] == 'A' || Seq[s] == 'T')
                    at++;
            }
            GC_Content = gc;
            AT_Content = at;
        }
        public static void G_C_A_T_Content(string Seq, out int A, out int C, out int G, out int T)
        {
            int g = 0;
            int a = 0;
            int c = 0;
            int t = 0;
            for (int i = 0; i < Seq.Length; i++)
            {
                if (Seq[i] == 'A')
                    a++;
                else if (Seq[i] == 'T')
                    t++;
                else if (Seq[i] == 'C')
                    c++;
                else if (Seq[i] == 'G')
                    g++;
            }
            G = g;
            C = c;
            T = t;
            A = a;
        }
        #endregion

        #region DNA Operations
        public static string Reversion(string Seq)
        {
            string Rev_Seq = "";
            char[] d = Seq.ToCharArray();
            Array.Reverse(d);
            for (int i = 0; i < d.Length; i++)
            {

                Rev_Seq += d[i];
            }

            return (string)Rev_Seq;

        }

        public static string DNA_complementry(string Seq)
        {
            /* this code in sequence toolStripButton in the complementry 
              ToolStripMenuItem to convert the DNA sequence
             from one strand to the other complementry strand 
            */

            string DNA_Comp = "";
            char[] d = Seq.ToCharArray();
            for (int n = 0; n < d.Length; ++n)
            {
                switch (d[n])
                {
                    case ('T'): d[n] = 'A'; break;
                    case ('A'): d[n] = 'T'; break;
                    case ('C'): d[n] = 'G'; break;
                    case ('G'): d[n] = 'C'; break;
                }
                DNA_Comp += Convert.ToString(d[n]);
            }

            return (string)DNA_Comp;
        }

        public static string merge(string tube1, string tube2)
        {
            tube1 = tube1 +System.Environment.NewLine+tube2;
            return tube1;
        }

        public static string[] seperate(string tube, string pattern)
        {
            string[] lines = tube.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            List<string> reservedStrings = new List<string>();
            List<string> removedStrings = new List<string>();
            string[] result = new string[2]; result[0] = ""; result[1] = "";
            foreach (var item in lines)
            {
                if (item.Contains(pattern))
                {
                    reservedStrings.Add(item);
                }
                else
                {
                    removedStrings.Add(item);
                }
            }
            foreach (var item in reservedStrings)
            {
                result[0] += item+Environment.NewLine;   
            }
            foreach (var item in removedStrings)
            {
                result[1] += item + Environment.NewLine;
            }
            return result;
        }

        public static string[] select(string tube, int length)
        {
            string[] lines = tube.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            List<string> reservedStrings = new List<string>();
            List<string> removedStrings = new List<string>();
            string[] result = new string[2]; result[0] = ""; result[1] = "";
            foreach (var item in lines)
            {
                if (item.Length==length)
                {
                    reservedStrings.Add(item);
                }
                else
                {
                    removedStrings.Add(item);
                }
            }
            foreach (var item in reservedStrings)
            {
                result[0] += item + Environment.NewLine;
            }
            foreach (var item in removedStrings)
            {
                result[1] += item + Environment.NewLine;
            }
            return result;
        }

        public static string[] sort(string tube)
        {
            string[] lines = tube.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            List<string> removedStrings = new List<string>();
            List<string> longest = new List<string>();
            List<string> shortest = new List<string>();
            string[] result = new string[3]; result[0] = ""; result[1] = ""; result[2] = "";
            int min = lines[0].Length, max = lines[0].Length;
            foreach (var item in lines)
            {
                if (item.Length<min)
                {
                    min = item.Length;
                }
                if (item.Length>max)
                {
                    max = item.Length;
                }
            }
            foreach (var item in lines)
            {
                if (item.Length==min)
                {
                    shortest.Add(item);
                }
                else if (item.Length==max)
                {
                    longest.Add(item);
                }
                else
                {
                    removedStrings.Add(item);
                }
            }
            foreach (var item in shortest)
            {
                result[0] += item + Environment.NewLine;
            }
            foreach (var item in longest)
            {
                result[1] += item + Environment.NewLine;
            }
            foreach (var item in removedStrings)
            {
                result[2] += item + Environment.NewLine;
            }
            return result;
        }

        public static string cut(string tube,string pattern)
        {
            
            string result = "";
            string[] lines = tube.Split(new string[] { pattern }, StringSplitOptions.None);
            
            foreach (var item in lines)
            {
                result += item+Environment.NewLine;
            }
            return result;
          
        }

        public static string appendHead(string tube, string pattern)
        {
            string result = "";
            string[] lines = tube.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = pattern + lines[i];
            }
            foreach (var item in lines)
            {
                result += item + Environment.NewLine;
            }
            return result;
        }
        public static string appendTail(string tube, string pattern)
        {
            string result = "";
            string[] lines = tube.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i]+pattern;
            }
            foreach (var item in lines)
            {
                result += item + Environment.NewLine;
            }
            return result;
        }

        public static string substitute(string tube, string pattern1, string pattern2)
        {
            string result = "";
            string[] lines = tube.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(pattern1))
                {
                    lines[i] = lines[i].Replace(pattern1, pattern2);
                }
            }
            
            foreach (var item in lines)
            {
                result += item + Environment.NewLine;
            }
            return result;
        }
        #endregion

    }
}
