namespace factoryMethod {
	interface Creator {
		public void someOperation() {
			// Some operation
		}

		void createProduct();
	}

	class Product1 : Creator {
		public void createProduct() {
			// Create product
		}
	}

	class Product2 : Creator {
		public void createProduct() {
			// Create product
		}
	}
}