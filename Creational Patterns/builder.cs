namespace builder {
	interface primaryBuilder {
		void reset();

		void setObj1Amt(int number);
		void setObj2Amt(int number);
		void setObj3Amt(int number);

		void addObj4();
		void addObj5();
	}

	class item1Builder : primaryBuilder {
		void setObj1Amt(int number) {
			// Set the amount of object 1 in item1 object
		}
		void setObj2Amt(int number) {
			// Set the amount of object 2 in item1 object
		}
		void setObj3Amt(int number) {
			// Set the amount of object 3 in item1 object
		}

		void addObj4() {
			// Adds object 4 to item1 object
		}
		void addObj5() {
			// Adds object 5 to item1 object
		}
		void addObj6() {
			// Adds object 6 to item1 object
		}

		item1 getResult() {
			// Give the built item1 object
		}
	}

	class item2Builder : primaryBuilder {
		void setObj1Amt(int number) {
			// Set the amount of object 1 in item2 object
		}
		void setObj2Amt(int number) {
			// Set the amount of object 2 in item2 object
		}
		void setObj3Amt(int number) {
			// Set the amount of object 3 in item2 object
		}

		void addObj4() {
			// Adds object 4 to item2 object
		}
		void addObj5() {
			// Adds object 5 to item2 object
		}
		void addObj6() {
			// Adds object 6 to item2 object
		}

		item2 getResult() {
			// Give the built item2 object
		}
	}

	class item1 {
		public item1();
	}
	class item2 {
		public item2();
	}
}