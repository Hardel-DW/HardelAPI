﻿namespace Harion.CustomRoles {

    public abstract class CustomRole<T> : RoleManager where T : CustomRole<T>, new() {
        private static T instance = null;

        private static readonly object Lock = new object();

        public static T Instance {
            get {
                lock (Lock) {
                    return instance ??= new T();
                }
            }
        }

        public T SetIntance {
            set {
                instance = value;
            }
        }

        protected CustomRole() : base(typeof(T)) { }
    }
}