// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Specialized;

namespace System.Web
{
    public abstract class HttpSessionStateBase : ICollection, IEnumerable
    {
        public virtual HttpSessionStateBase Contents => throw new NotImplementedException();

        public virtual bool IsReadOnly => throw new NotImplementedException();

        public virtual NameObjectCollectionBase.KeysCollection Keys => throw new NotImplementedException();

        public virtual string SessionID => throw new NotImplementedException();

        public virtual int Timeout
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual object this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual object this[string name]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual void Abandon() => throw new NotImplementedException();

        public virtual void Add(string name, object value) => throw new NotImplementedException();

        public virtual void Clear() => throw new NotImplementedException();

        public virtual void Remove(string name) => throw new NotImplementedException();

        public virtual void RemoveAll() => throw new NotImplementedException();

        public virtual void RemoveAt(int index) => throw new NotImplementedException();

        public virtual void CopyTo(Array array, int index) => throw new NotImplementedException();

        public virtual int Count => throw new NotImplementedException();

        public virtual bool IsSynchronized => throw new NotImplementedException();

        public virtual object SyncRoot => throw new NotImplementedException();

        public virtual IEnumerator GetEnumerator() => throw new NotImplementedException();
    }
}
