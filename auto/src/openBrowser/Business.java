package openBrowser;

import java.io.File;
import java.util.Date;
import java.util.Random;

import org.apache.commons.io.FileUtils;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.TakesScreenshot;
import org.openqa.selenium.WebDriver;

import com.ibm.icu.text.SimpleDateFormat;

import Model.TestInfo;

public class Business {
	
	public TestInfo getTestCaseInfo() {
		//nho goi API, HOAC DOC DB NHA ma!!!
		TestInfo f = new TestInfo();
		f.setCsv_path("csv.csv");
		f.setCount_loop(5);
		return f;
	}
	
	public String randomCharacter() {
		  String upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		  String lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
		  String numbers = "0123456789";
		  String specialCharacter="^[^<>{}\"/|;:.,~!?@#$%^=&*\\]\\\\()\\[¿§«»ω⊙¤°℃℉€¥£¢¡®©0-9_+]*$";

		  // combine all strings
		  String alphaNumeric = upperAlphabet + lowerAlphabet + numbers+specialCharacter;

		  // create random string builder
		  StringBuilder sb = new StringBuilder();

		  // create an object of Random class
		  Random random = new Random();

		  // specify length of random string
		  int length = 300;

		  for(int i = 0; i < length; i++) {

		    // generate random index number
		    int index = random.nextInt(alphaNumeric.length());

		    // get character specified by index
		    // from the string
		    char randomChar = alphaNumeric.charAt(index);

		    // append the character to string builder
		    sb.append(randomChar);
		  }

		  String randomString = sb.toString();
		  return randomString;
		 // System.out.println("Random String is: " + randomString);

		}

		public static String getScreenshot(WebDriver driver, String screenshotName) throws Exception {
		    //below line is just to append the date format with the screenshot name to avoid duplicate names		
		    String dateName = new SimpleDateFormat("yyyyMMddhhmmss").format(new Date());
		TakesScreenshot ts = (TakesScreenshot) driver;
		File source = ts.getScreenshotAs(OutputType.FILE);
		    //after execution, you could see a folder "FailedTestsScreenshots" under src folder
		String destination = System.getProperty("user.dir") + "/FailedTestsScreenshots/"+screenshotName+dateName+".png";
		File finalDestination = new File(destination);
		FileUtils.copyFile(source, finalDestination);
		    //Returns the captured file path
		return destination;
		}
}
