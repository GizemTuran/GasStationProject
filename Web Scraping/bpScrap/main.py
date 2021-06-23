from selenium import webdriver
from selenium.webdriver.support.ui import Select
import time
import pyodbc
from bs4 import BeautifulSoup as soup

conn = pyodbc.connect("DRIVER={SQL Server}; Server=DSK6;User=sa;Password=1234;Database=GasStation")
cursor = conn.cursor()
def translate(text):
  i = 0
  temp = ""
  for char in text:

    if char == 'ı' or char == 'I' or char == 'İ' or char =='Ý':
      char = 'i'
    elif char == 'ğ' or char == 'Ğ' or char=='Ð':
      char = 'g'
    elif char == 'ü' or char == 'Ü':
      char = 'u'
    elif char == 'ş' or char == 'Ş' or char=='Þ':
      char = 's'
    elif char == 'ö' or char == 'Ö':
      char = 'o'
    elif char == 'ç' or char == 'Ç':
      char = 'c'
    temp += str.lower(char)
    i += 1
  return temp
PATH = "C:\Program Files (x86)\chromedriver.exe"
driver = webdriver.Chrome(PATH)
driver.get("https://bppompafiyatlari.com/")
i=1

while i<83:

    element = driver.find_element_by_id("City")
    drp = Select(element)
    drp.select_by_index(i)
    time.sleep(0.2)
    driver.find_element_by_xpath('//*[@id="form0"]/div/div[3]/div/button').click()
    time.sleep(0.5)
    table=driver.find_element_by_class_name("table")
    time.sleep(0.5)
    content= driver.page_source

    page=soup(content,"html.parser")
    tablo=page.find('table')
    List=tablo.find_all("td")
    item=9
    while len(List) > item:
        print(translate(List[item-9].text) + " " + translate(List[item-8].text) + " " + List[item-7].text + " " + List[
            item-5].text)
        cursor.execute("exec AddtoBP @il='" + List[item-9].text + "',@ilce='" + translate(List[item-8].text) + "',@benzin = '" + str(
            List[item-7].text) + "',@motorin = '" + str(List[item-5].text) + "';").commit()

        item+=10

    i+=1
conn.close()
driver.quit()

