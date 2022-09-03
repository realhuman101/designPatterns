namespace singleton {
	class Singleton {
		private Singleton() {
			// Do stuff
		}

		private static Singleton instance;

		public static Singleton getInstance() {
			if (instance == null) {
				instance = new Singleton();
			}

			return instance;
		}

		public void someStuff() {
			// Some stuff here
		}
	}
}