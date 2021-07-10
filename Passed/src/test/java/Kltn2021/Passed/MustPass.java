package Kltn2021.Passed;

import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.support.ui.Select;
import org.testng.annotations.BeforeTest;
import org.openqa.selenium.Alert;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.NoAlertPresentException;
import org.openqa.selenium.NoSuchElementException;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.WindowType;
import org.openqa.selenium.TakesScreenshot;
import com.opencsv.CSVReader;
import com.opencsv.exceptions.CsvValidationException;

import java.awt.Robot;
import java.awt.event.KeyEvent;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.text.SimpleDateFormat;

import org.apache.commons.io.FileUtils;
import org.openqa.selenium.OutputType;
import java.util.List;
import java.util.Random;
import java.util.ArrayList;
import com.relevantcodes.extentreports.ExtentReports;
import com.relevantcodes.extentreports.ExtentTest;
import com.relevantcodes.extentreports.LogStatus;
import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.ThreadContext;
import org.junit.jupiter.api.Test;

import java.time.Duration;
import java.time.LocalDate;
import java.util.Date;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MustPass {

	private static Logger Log = null;
	static WebDriver webDr;
	static List<String> myList = new ArrayList<String>();
	private static CSVReader csvReader;
	static String[] csvCell;
	public static ExtentReports extent;
	public static ExtentTest test;
	public static String getdata;
	public static String reportPath;

	private static String STRING = "STRING";
	private static String NUMBER = "NUMBER";
	private static String NUMBERRANGE = "NUMBERRANGE";
	private static String DATE = "DATE";
	private static String DATETIME = "DATETIME";
	private static String DELIMET = "\\{\\{(.*?)\\}\\}";
	private static String alertMessage;
	private static int numberPass;
	private static int numberFail;
	private static int totalTestcase;

	public static void main(String[] args) throws Exception {
//		reportPath = args[1];
//		
//		ThreadContext.put("fileName", args[2]);
//		Log = LogManager.getLogger();
//		if(args[3]=="0") {
//			openBrowser();
//		}else {
//			headlessBrowser();
//		}
//		
//		check(args[0]);
//		closeBrowser();
//		
		
		

		reportPath = "C:\\Users\\HangPham\\Downloads\\Passed\\data\\testInput1.html";
		ThreadContext.put("fileName", "C:\\Users\\HangPham\\Downloads\\Passed\\logs\\Logs.log");
		Log = LogManager.getLogger();
		String driverExecutablePath = System.getProperty("user.dir") + "\\chromedriver.exe";
		openBrowser();
		check("H:\\DataTest\\hcmute-login.csv");
		closeBrowser();

	}

	public static void openBrowser() throws Exception {

		String driverExecutablePath = System.getProperty("user.dir") + "\\chromedriver.exe";
		System.setProperty("webdriver.chrome.driver", driverExecutablePath);
		webDr = new ChromeDriver();
		webDr.manage().window().maximize();
		Log.info("New driver instantiated");
		extent = new ExtentReports(reportPath, true);
		extent.loadConfig(new File(System.getProperty("user.dir") + "\\extent-config.xml"));
		System.out.println(getdata);
	}

	
	public static void headlessBrowser() throws Exception {

		String driverExecutablePath = System.getProperty("user.dir") + "\\chromedriver.exe";
		System.setProperty("webdriver.chrome.driver", driverExecutablePath);
	
		
		ChromeOptions options = new ChromeOptions();
        
        //add the headless argument
        options.addArguments("headless");
        
        //pass the options parameter in the Chrome driver declaration
       webDr = new ChromeDriver(options);
       
		Log.info("New driver instantiated");
		extent = new ExtentReports(reportPath, true);
		extent.loadConfig(new File(System.getProperty("user.dir") + "\\extent-config.xml"));
		System.out.println(getdata);
	}
	
	public static void check(String val) throws Exception {
		csvReader = new CSVReader(new FileReader(val));
		csvCell = csvReader.readNext();
		csvCell = csvReader.readNext();
		webDr.get(csvCell[1]);

		webDr.manage().timeouts().implicitlyWait(Duration.ofSeconds(10));
		Log.info("Web application launched");
		String s1 = "name";
		String s2 = "click";
		String s3 = "enter";
		String s4 = "alert";
		String s5 = "result";
		String s6 = "dropdown";
		String s7 = "newtab";
		String s8 = "compare_link";
		String s9 = "green_inner_element";
		String s10 = "red_inner_element";

		while ((csvCell = csvReader.readNext()) != null) {
			// name testcase
			String listrandom = doRandomProcessing(csvCell[2]);
			if (csvCell[0].equals(s1) == true) {
				test = extent.startTest(csvCell[1]);
				Log.info(csvCell[1]);
				myList.clear();
			}
			// click
			else if (csvCell[0].equals(s2) == true) {
				if (checkLocationExist()) {
					webDr.findElement(By.xpath(csvCell[1])).click();
					Thread.sleep(1000);
					Log.info(csvCell[1]);
				} else {
					findNextTestcase();

				}
			}
			// enter
			else if (csvCell[0].equals(s3) == true) {
				// check exit

				if (checkLocationExist()) {
					WebElement enter = webDr.findElement(By.xpath(csvCell[1]));
					enter.clear();
					// random
					if (csvCell[2] != listrandom) {
						enter.sendKeys(listrandom);
						Thread.sleep(1000);
						Log.info(listrandom);
						myList.add(listrandom);
					} else {
						enter.sendKeys(csvCell[2]);
						Thread.sleep(1000);
						Log.info(listrandom);
						myList.add(csvCell[2]);
					}
				} else {
					findNextTestcase();

				}
			}

			// dropdown
			else if (csvCell[0].equals(s6) == true) {

				if (checkLocationExist()) {

					Select se = new Select(webDr.findElement(By.xpath(csvCell[1])));
					// Select the option by index
					se.selectByIndex(Integer.parseInt(csvCell[2]));
				} else {
					findNextTestcase();

				}
			}
			
			// newtab
			else if (csvCell[0].equals(s7) == true) {

				WebDriver newTab = webDr.switchTo().newWindow(WindowType.TAB);
				newTab.get(csvCell[1]);
				System.out.println(webDr.getTitle());

			}
			// result
			else {//compare-link
				if (csvCell[1].equals(s8)) {
					webDr.getTitle();
					Result(csvCell[2], webDr.getTitle());
					System.out.println(webDr.getTitle());

				}
				//innergreen-element
				else if(csvCell[1].equals(s9) == true) {
					String expectInnerGreen = csvCell[2];
					Thread.sleep(1000);
					String innerGreen = webDr.findElement(By.xpath("//div[@class='alert alert-info']")).getAttribute("innerHTML");
					String innerGreenTrim=innerGreen.trim().replace("\r\n", " ").replace("\n", " ").trim();
					Thread.sleep(1000);
					Result(expectInnerGreen, innerGreenTrim);
					//Result(expect, innerRedTrim);
				}
				//innerred-element
				else if(csvCell[1].equals(s10) == true) {
					String expectInnerRed = csvCell[2];
					Thread.sleep(1000);
					String innerRed = webDr.findElement(By.xpath("//div[@class='alert alert-danger']")).getAttribute("innerHTML");			
					String innerRedTrim=innerRed.trim().replace("\r\n", " ").replace("\n", " ").trim();
					Thread.sleep(1000);					
					
					Result(expectInnerRed, innerRedTrim);
				}
				//alert
				else if (csvCell[1].equals(s4)) {
					handleAlert();
					String expect = csvCell[2];
					Result(expect, alertMessage);
				} else {//compare
					if (checkLocationExist()) {
						String actual = webDr.findElement(By.xpath(csvCell[1])).getText();
						String expect = csvCell[2];
						Thread.sleep(1000);
						Result(expect, actual);
					} else {
						findNextTestcase();

					}
				}
			}
		}
	}

	

	public static String[] findNextTestcase() throws CsvValidationException, IOException {
		String s10 = "result";
		while (!(csvCell[0]).equals(s10)) {
			csvCell = csvReader.readNext();

		}
		// return a line have "result" and then run while ((csvCell =csvReader.readNext()) != null)
		// csvCell now is "name"
		return csvCell;
	}

	public static boolean checkLocationExist() {

		try {
			Boolean isPresent = webDr.findElements(By.xpath(csvCell[1])).size() > 0;
			return true;
		} catch (NoSuchElementException ex) {
			// Do nothing
			Log.error("Location xpath [" + csvCell[1] + "] can not find!");
			test.log(LogStatus.FAIL, "Location xpath [ " + csvCell[1] + " ] can not find!");
			numberFail++;
			return false;
		}

	}

	public static void handleAlert() {

		if (isAlertPresent()) {

			Alert alert = webDr.switchTo().alert();
			alertMessage = webDr.switchTo().alert().getText();
			System.out.println(alert.getText());
			alert.accept();

		}
	}

	public static boolean isAlertPresent() {

		try {

			webDr.switchTo().alert();
			return true;

		} catch (NoAlertPresentException ex) {
			return false;

		}

	}

	public static String getScreenshot(WebDriver driver, String screenshotName) throws Exception {
		//Thread.sleep(1000);
		TakesScreenshot ts = (TakesScreenshot) driver;
		File source = ts.getScreenshotAs(OutputType.FILE);
		String destination = System.getProperty("user.dir") + "/FailedTestsScreenshots/" + screenshotName + "test"
				+ ".png";
		File finalDestination = new File(destination);
		FileUtils.copyFile(source, finalDestination);
		return destination;
	}
	
	public static void Result(String expect, String actual) throws Exception {
		
		if (expect.equals(actual) == true) {
			test.log(LogStatus.INFO, "Test Passed");
			if (!myList.isEmpty()) {
				test.log(LogStatus.PASS, "Value=" + myList);
			}

			test.log(LogStatus.PASS, "Expected [" + expect + "] found [" + actual + "]");
			myList.clear();
			numberPass++;
		} else if (expect.equals(actual) == false) {
			test.log(LogStatus.INFO, "Test Failed");
			if (!myList.isEmpty()) {
				test.log(LogStatus.FAIL, "Value=" + myList);
			}

			//Thread.sleep(1000);
			test.log(LogStatus.FAIL, "Expected [" + expect + "] but found [" + actual + "]");
			String screenshotPath = getScreenshot(webDr, randomCharacter());
			test.log(LogStatus.FAIL, test.addScreenCapture(screenshotPath));
			myList.clear();
			numberFail++;
		}

	}

	public static String randomCharacter() {
		String upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		String lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
		String numbers = "0123456789";

		// combine all strings
		String alphaNumeric = upperAlphabet + lowerAlphabet + numbers;

		// create random string builder
		StringBuilder sb = new StringBuilder();

		// create an object of Random class
		Random random = new Random();

		// specify length of random string
		int length = 10;

		for (int i = 0; i < length; i++) {

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

	

	public static void closeBrowser() throws InterruptedException {

		totalTestcase = numberPass + numberFail;
		Log.info("Browser closed");
		Log.info(
				"--------------------------------------------------------------------------------------------------------------");
		Log.info("Total testcase: " + totalTestcase + " |   Pass: " + numberPass + " |   Fail: " + numberFail);
		Log.info(
				"--------------------------------------------------------------------------------------------------------------");
		Thread.sleep(100);
		webDr.quit();
		extent.flush();

	}

	// Tạo Random
	public static String doRandomProcessing(String str) {

		List<String> tokensVal = getAllParttern(str);
		for (String token : tokensVal) {
			// str.replaceFirst("(?:H)+", "B");
			String ftoken = "{{" + token + "}}";
			str = replaceFirstOccurrenceOfString(str, ftoken, processPattern(token));
			// System.out.println(processPattern(token));
		}
		// System.out.println(str);
		return str;
	}

	private static String replaceFirstOccurrenceOfString(String inputString, String stringToReplace,
			String stringToReplaceWith) {
		int length = stringToReplace.length();
		int inputLength = inputString.length();

		int startingIndexofTheStringToReplace = inputString.indexOf(stringToReplace);

		String finalString = inputString.substring(0, startingIndexofTheStringToReplace) + stringToReplaceWith
				+ inputString.substring(startingIndexofTheStringToReplace + length, inputLength);
		return finalString;
	}

	private static List<String> getAllParttern(String str) {
		List<String> list = new ArrayList<String>();
		while (!SplitPattern(str).equals("")) {
			String x = SplitPattern(str);
			str = str.substring(str.indexOf(x) + 1, str.length());
			list.add(x);
		}
		return list;
	}

	private static String SplitPattern(String raw) {
		Pattern pattern = Pattern.compile(DELIMET);
		Matcher matcher = pattern.matcher(raw);
		if (matcher.find()) {
			return matcher.group(1);
		}
		return "";
	}

	private static String getSecondPart(String pattern) {
		int index = pattern.indexOf('|');
		int lastIndex = pattern.lastIndexOf('|');
		if (index == lastIndex) {
			String thePart = pattern.substring(index + 1, pattern.length());
			return thePart;
		} else {
			String thePart = pattern.substring(index + 1, lastIndex);
			return thePart;
		}
	}

	private static String getLastPart(String pattern) {
		int lastIndex = pattern.lastIndexOf('|');
		String thePart = pattern.substring(lastIndex + 1, pattern.length());
		return thePart;
	}

	private static String processPattern(String pattern) {
		String newChar = pattern;
		try {

			long occurance = pattern.chars().filter(ch -> ch == '|').count();
			if (occurance == 0) {
				if (pattern.contains(STRING)) {
					// {{STRING}}
					int min = getRandomRange(1, 20);
					return getAlphaNumericString(min);
				}
				if (pattern.contains(DATE)) {
					// {{DATE}}
					int min = getRandomRange(1980, 2020);
					return createRandomDate(min, 2021).toString();
				}
				if (pattern.contains(NUMBER)) {
					// {{NUMBER}}
					int min = getRandomRange(1, 20);
					return String.valueOf(generateRandomNumber(min));
				}
			}
			if (occurance == 1) {
				// {{STRING|LEN}}
				// {{NUMBER|LEN}}
				int theValue = Integer.valueOf(getSecondPart(pattern));
				if (pattern.contains(NUMBER)) {
					// {{NUMBER}}
					int min = theValue;
					return String.valueOf(generateRandomNumber(min));
				}
				if (pattern.contains(STRING)) {
					// {{NUMBER}}
					int min = theValue;
					return String.valueOf(getAlphaNumericString(min));
				}
			}
			if (occurance == 2) {
				// {{DATE|FROM|TO}}
				// {{NUMBERRANGE|FROM|TO}}

				if (pattern.contains(NUMBERRANGE)) {
					// {{DATE}
					int theValue = Integer.valueOf(getSecondPart(pattern));
					int TheSecondValue = Integer.valueOf(getLastPart(pattern));
					return String.valueOf(getRandomRange(theValue, TheSecondValue));
				}
				if (pattern.contains(DATETIME)) {
					String theValue = getSecondPart(pattern);
					String TheSecondValue = getLastPart(pattern);
					Date date = randomDateTime(theValue, TheSecondValue);
					return new SimpleDateFormat("yyyy.MM.dd HH:mm:ss").format(date);
				}
				if (pattern.contains(DATE)) {
					int theValue = Integer.valueOf(getSecondPart(pattern));
					int TheSecondValue = Integer.valueOf(getLastPart(pattern));
					return createRandomDate(theValue, TheSecondValue).toString();
				}
			}
		} catch (Exception e) {
			// TODO: handle exception
			// newChar = e.getMessage();
		}
		return newChar;
	}

	// BE CARE FULL OF TOUCHING ALL THE THINSG BELLOW...
	private static String getAlphaNumericString(int n) {
		String AlphaNumericString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "0123456789" + "abcdefghijklmnopqrstuvxyz";
		StringBuilder sb = new StringBuilder(n);
		for (int i = 0; i < n; i++) {
			int index = (int) (AlphaNumericString.length() * Math.random());
			sb.append(AlphaNumericString.charAt(index));
		}
		return sb.toString();
	}

	private static int getRandomRange(int min, int max) {
		return (int) Math.floor(Math.random() * (max - min + 1)) + min;
	}

	private static long generateRandomNumber(int n) {
		double tenToN = Math.pow(10, n), tenToNMinus1 = Math.pow(10, n - 1);
		long randNum = (long) (Math.random() * (tenToN - tenToNMinus1) + tenToNMinus1);
		return randNum;
	}

	private static int createRandomIntBetween(int start, int end) {
		return start + (int) Math.round(Math.random() * (end - start));
	}

	private static LocalDate createRandomDate(int startYear, int endYear) {
		int day = createRandomIntBetween(1, 28);
		int month = createRandomIntBetween(1, 12);
		int year = createRandomIntBetween(startYear, endYear);
		return LocalDate.of(year, month, day);
	}

	private static Date randomDateTime(String beginDate, String endDate) {
		try {
			SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
			Date start = format.parse(beginDate);
			Date end = format.parse(endDate);

			if (start.getTime() >= end.getTime()) {
				return null;
			}
			long date = random(start.getTime(), end.getTime());
			return new Date(date);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return null;
	}

	private static long random(long begin, long end) {
		long rtn = begin + (long) (Math.random() * (end - begin));
		if (rtn == begin || rtn == end) {
			return random(begin, end);
		}
		return rtn;
	}

}