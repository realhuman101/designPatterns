namespace abstractFactory {
	interface factory {
		public void createProduct1();
		public void createProduct2();
	}

	class concreteFactory1 : factory {
		public void createProduct1() {
			// Create product 1 in concreteFactory 1 variant
		}

		public void createProduct2() {
			// Create product 2 in concreteFactory 1 variant
		}
	}

	class concreteFactory2 : factory {
		public void createProduct1() {
			// Create product 1 in concreteFactory 2 variant
		}

		public void createProduct2() {
			// Create product 2 in concreteFactory 2 variant
		}
	}
}