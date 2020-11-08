using System.Collections.Generic;

namespace Trabalho_de_IA {
    class OrderList {

        public OrderList() {
        }

        public List<int> doOrder(List<int> ListToOrder) {
            int[] vector = new int[ListToOrder.Count];
            int aux = 0;
            foreach(int i in ListToOrder) {
                vector[aux] = i;
                aux++;
            }
            for(int i=0; i<ListToOrder.Count; i++) {
                for(int j=i+1; j<ListToOrder.Count; j++) {
                    if(vector[i] > vector[j]) {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
            List<int> ListToReturn = new List<int>();
            for (int i = 0; i < ListToOrder.Count; i++) {
                ListToReturn.Add(vector[i]);
            }
            return ListToReturn;
        }
    }
}
