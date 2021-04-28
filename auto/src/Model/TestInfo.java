package Model;

public class TestInfo {
	private String csv_path;
	private int count_loop;
	public int getCount_loop() {
		return count_loop;
	}

	public void setCount_loop(int count_loop) {
		this.count_loop = count_loop;
	}

	public String getCsv_path() {
		return csv_path;
	}

	public void setCsv_path(String csv_path) {
		this.csv_path = csv_path;
	}
	public TestInfo() {
		count_loop = 1;
	}
}
