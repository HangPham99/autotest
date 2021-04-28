package openBrowser;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class InitialBrowsers {
	static String driver = "chromedriver.exe";
	static WebDriver webDr;

	public WebDriver getDriver() {
		if(webDr == null) {
			webDr = new ChromeDriver();
			webDr.manage().window().maximize(); 
			webDr.manage().timeouts().implicitlyWait(50, TimeUnit.SECONDS);	
		}
		return webDr;
	}
}
