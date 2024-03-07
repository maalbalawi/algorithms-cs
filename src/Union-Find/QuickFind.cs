using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Algorithms.UnionFind {



//eager approach
    public class QuickFind {
        int[] uf;

        // two objects are connected if they shre same array entry value
        public QuickFind(int N)
        {
            uf = new int[N];
            for (int i =0; i< uf.Length; i++)
                uf[i] = i;
        }

        //change reference of all entries to last one
        public void Union(int p, int q) {
            var qid = uf[q];
            var pid = uf[p];
            if (qid == pid) return;
            // assign the id of q to p
            for (int i=0 ; i < uf.Length; i++) {
                if (uf[i] == pid)
                    uf[i] = qid;
            }
        }

        public int Find(int p) {
                return uf[p];
        }
    }
}