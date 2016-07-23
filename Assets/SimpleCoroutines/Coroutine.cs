using System;
using System.Collections;

namespace SimpleCoroutines
{
    public class Coroutine
    {
        private String _id;
        private IEnumerator _block;
        private Boolean _canceled;

        public Coroutine(String id, IEnumerator block)
        {
            _id = id;
            _block = block;
            _canceled = false;
        }

        public void Cancel()
        {
            _canceled = true;
        }

        public bool IsCanceled()
        {
            return _canceled;
        }

        public void setCanceled(bool can)
        {
            _canceled = can;
        }

        public IEnumerator GetBlock()
        {
            return _block;
        }

        public String GetId()
        {
            return _id;
        }
    }
}
