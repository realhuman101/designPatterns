namespace prototype {
	interface Prototype {
		Prototype clone();
	}

	class Object : Prototype {
		public Object() {
			// Do stuff here
		}

		Prototype clone() {
			// Clone object
		}
	}
}