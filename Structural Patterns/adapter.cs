namespace adapter {
	class item1 {
		string getRequest();
	}

	class item2 {
		public string specificRequest() {
			return "something specific";
		}
	}

	class adapter : item2 {
		private item2 target;

		public adapter(item2 targetObj) {
			target = targetObj;
		}

		public string getRequest() {
			return this.target.specificRequest();
		}
	}

	// Using the adapter
	class program {
		public program() {
			item2 adaptee = new item2();
			item1 target = new adapter(adaptee);
		}
	}
}