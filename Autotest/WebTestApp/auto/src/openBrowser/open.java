package openBrowser;

import org.testng.annotations.Test;
import org.testng.asserts.SoftAssert;
import org.testng.annotations.BeforeTest;

import java.util.concurrent.TimeUnit;
import java.util.stream.Collectors;

import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.TakesScreenshot;
import com.aventstack.extentreports.reporter.ExtentHtmlReporter;
import com.ibm.icu.text.SimpleDateFormat;
import com.opencsv.CSVReader;
import com.relevantcodes.extentreports.ExtentReports;
import com.relevantcodes.extentreports.ExtentTest;
import com.relevantcodes.extentreports.LogStatus;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;

import org.testng.AssertJUnit;
import org.testng.ITestResult;
import org.testng.Assert;
import java.util.concurrent.TimeUnit;

import org.apache.commons.io.FileUtils;
import org.apache.commons.net.nntp.NewGroupsOrNewsQuery;
import org.openqa.selenium.Alert;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.OutputType;
import org.openqa.selenium.TakesScreenshot;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

import org.testng.annotations.AfterClass;
import org.testng.annotations.AfterGroups;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.AfterSuite;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.BeforeSuite;

import com.aventstack.extentreports.reporter.ExtentHtmlReporter;
import com.gargoylesoftware.htmlunit.util.StringUtils;
import com.github.michaelbull.result.Result;
import com.ibm.icu.impl.StringRange;
import com.ibm.icu.text.SimpleDateFormat;
import com.opencsv.CSVReader;
import com.relevantcodes.extentreports.ExtentReports;
import com.relevantcodes.extentreports.ExtentTest;
import com.relevantcodes.extentreports.LogStatus;



import java.util.ArrayList;
import java.util.Arrays;

import com.opencsv.exceptions.CsvValidationException;
import net.bytebuddy.agent.builder.AgentBuilder.Identified.Extendable;
import net.bytebuddy.asm.Advice.Enter;

import com.opencsv.CSVWriter;

import java.io.BufferedReader;

import java.io.StringWriter;
import java.util.List;
import java.util.Random;
import java.util.Scanner;
import java.util.Scanner.*;

import java.io.FileReader.*;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Date;


import java.lang.*;



public class open {
			WebDriver webDr;
			//read file hp.csv
			String CSV_PATH = "csv.csv";
			private static final String SEPARATOR = ",";
			SoftAssert softAssert = new SoftAssert();
		   
		    private CSVReader csvReader;
		    String[] csvCell;
		    
			 //extent-report
			public ExtentHtmlReporter htmlReporter;
			public ExtentReports extent;
			public  ExtentTest test;
  @BeforeTest
  public void beforeTest() throws Exception {
	  randomCharacter();
		
			final String driver = "chromedriver.exe";
			System.setProperty("webdriver.chrome.driver",driver);
			webDr = new ChromeDriver();
			webDr.manage().window().maximize(); 
			webDr.manage().timeouts().implicitlyWait(50, TimeUnit.SECONDS);			
			//csv read
			//BufferedReader br = new BufferedReader(new FileReader(CSV_PATH));
			csvReader = new CSVReader(new FileReader(CSV_PATH));
			//read first line
			csvCell = csvReader.readNext();	
			//open url in csv file
			webDr.get(csvCell[1]);
			
			//report
			extent = new ExtentReports (System.getProperty("user.dir") +"/test-output/TestReport.html",true);
			extent.loadConfig(new File(System.getProperty("user.dir")+"\\extent-config.xml"));
			 
  }
  @Test
  public void check() throws Exception {
	  String s1="click";
	  String s2="enter";
	  String s3="result";
	  String s4="resultlink";
	  String s5="value";
	  

		
		
		
	  StringBuilder sb = new StringBuilder();
	 try (PrintWriter writer = new PrintWriter(new File("test.csv"))) {
		 sb.append(","+"username,"+"password,"+"result");
		 sb.append('\n');

          
          while (( csvCell = csvReader.readNext()) != null)  {
        	  
        	  //Bat dau la TC
        	  if (csvCell[0].startsWith("TC")==true) {
        		  sb.append(csvCell[0]);
    			  writer.write(sb.toString()+"\n"+",");
    			  test = extent.startTest(csvCell[0]);
			}
      		//click
        	  else if(csvCell[1].equals(s1)==true) {
    			  webDr.findElement(By.xpath(csvCell[2])).click();
    		  }
        	  //enter
    		  else if(csvCell[1].equals(s2)==true) {
    			  WebElement enter = webDr.findElement(By.xpath(csvCell[2]));
    			  enter.clear();
    			  if(csvCell[3].equals(s5)==true){
         			 
        			  enter.sendKeys(randomCharacter());
        			  sb.append(randomCharacter());
        			  writer.write(sb.toString()+",");
    			  }
    			  else {
    			  enter.sendKeys(csvCell[3]);
    			  sb.append(csvCell[3]);
    			  writer.write(sb.toString()+",");
    			  }
    			  
    		  }
    		//result
    		  else if (csvCell[1].equals(s3)==true){
    				 String expect= webDr.findElement(By.xpath(csvCell[2])).getText();
    				 //String actual=expect4.trim().replace("\r\n", " ").replace("\n", " ").trim();
    				 String actual=csvCell[3];
    				 //if using assertEquals fail, it stop run, and finish.
    				//AssertJUnit.assertEquals(expect, actual);
    				 softAssert.assertEquals(expect, actual);
    				 
    				 if(expect.equals(actual)) {
    					 test.log(LogStatus.PASS,"Test Passed");
    					 sb.append("Pass"+"\n");
    					 
    	    			  writer.write(sb.toString());
    				 }
    				 else  {
    					 test.log(LogStatus.FAIL,"Test Failed");
    					 sb.append("Fail"+"\n");
    					 writer.write(sb.toString());
    				 }
    			}
    	
        	  //result link
    		  else {
    			  
    			  String expectLink=webDr.getCurrentUrl();    			  
    				String actualLink=csvCell[2];
    				//Assert.assertEquals(expectLink, actualLink);
    				if(expectLink.equals(actualLink)) {
    					test.log(LogStatus.PASS,"Test Passed");
   					 sb.append("Pass"+"\n");  					 
   	    			  writer.write(sb.toString());
   				 }
   				 else {
   					 test.log(LogStatus.FAIL,"Test Failed");
   					 sb.append("Fail"+"\n");
   					 writer.write(sb.toString());
   				 }
    		  }
    			  Thread.sleep(2000);
    			  
    			  sb = new StringBuilder();
    			  Thread.sleep(2000);
    		  }
          
          softAssert.assertAll();
          Thread.sleep(2000);
         
          writer.close();
            } 
	 catch (FileNotFoundException e) {
              System.out.println(e.getMessage());
            }
	
	 
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

@AfterMethod
public void getResult(ITestResult result) throws Exception{
	if(result.getStatus() == ITestResult.FAILURE){
		test.log(LogStatus.FAIL, "Test Case Failed is "+result.getName());
		test.log(LogStatus.FAIL, "Test Case Failed is "+result.getThrowable());
		//To capture screenshot path and store the path of the screenshot in the string "screenshotPath"
                    //We do pass the path captured by this mehtod in to the extent reports using "logger.addScreenCapture" method. 			
                    String screenshotPath = open.getScreenshot(webDr, result.getName());
		//To add it in the extent report 
                    test.log(LogStatus.FAIL, test.addScreenCapture(screenshotPath));
	}else if(result.getStatus() == ITestResult.SKIP){
		test.log(LogStatus.SKIP, "Test Case Skipped is "+result.getName());
	}
	extent.endTest(test);
}
	

  @AfterTest
  public void afterTest() throws InterruptedException {
	  Thread.sleep(1500);		
		webDr.quit();
		extent.flush();
  }

}
