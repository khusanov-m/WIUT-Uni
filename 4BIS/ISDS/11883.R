#------------------------ WESTMINSTER INTERNATIONAL UNIVERSITY IN TASHKENT -----------------------#
#-------------------------- INTRODUCTION TO STATISTICS AND DATA SCIENCE --------------------------#
#------------------------------- PORTFOLIO OF INDIVIDUAL EXERCISES -------------------------------#

# Submission Instructions: You must rename this file with your own student ID and upload it in compressed (zipped) format.
# Double check that your zipped file is not corrupted and can be unzipped by the grader.
# Including comments for each task is a MUST. You can add your explanations as comments.

ID <- 11883       # TO DO: <--- Insert your ID in front of the hash sign. Do not include the zeros (0's) in the beginning of your ID.
             # For example, if your ID is 00010200, then you need to enter your ID as 10200.
             # Failure to provide the ID results in 0 mark. 

# Some exercises require the student to insert his/her last 4 digits of ID as abcd. 
# For example, a student with an ID of 10123 has the following values: a = 0, b = 1, c = 2, d = 3.
# You must only provide the R code which will store the correct answer in the given variable names. DO NOT use rounding functions for your answers.
# You can add additional rows above the answer line if you have more than one line of code as a solution.
# But you must store the final code into the variable names provided in each task.
# You can use any packages of R to solve these tasks, but you must include the installation and loading codes in the section provided below.  
# DO NOT CHANGE THE VARIABLE NAMES (e.g. keep answer1_a, answer2, etc. as they are).
# We will be given full marks only if your code provides the correct answer. 
# There is no partial credit for these tasks. Your solutions will be mostly checked by the computer (R itself) with minimal effort from the human graders.
# Therefore, be very careful/mindful about your answers and what they produce.

#--------------------------------------PACKAGE INSTALLATION AND LOADING PART-----------------------# 
# Skip this part if you are only using the Base package of R.
# If you use any packages other than the base package, 
# please add the installation and loading codes here, like below (without #):
# install.packages("package_name")
# library(package_name)

install.packages("quantmod")
library(quantmod)


                                                              

#-------------------------------------END OF PACKAGE INSTALLATIONS AND LOADING---------------------# 

a <- 1
b <- 8
c <- 8
d <- 3

#------ TASK 1 -------# [12 marks]
# a. Write a R code to create a vector of integer numbers from (1+8=9) to (8+3+20=31). Here, a,b,c,d are your student ID digits.

# from 9 to 31
vector1 <- c(9:31)

answer1_a <- vector1         # TO DO: replace NULL with your correct code.

# b. Add the values of first (3+2=5) elements of vector from part a.

# sum of first 5 values = 9 + 10 + 11 + 12 + 13
vector2 <- sum(vector1[0:5])
answer1_b <-  vector2        # TO DO: replace NULL with your correct code.

#c. Compute the sum of squares of a, b, c, d.

# to use exponent = ** or ^
answer1_c <-  sum(a**2, b**2, c**2, d**2)        # TO DO: replace NULL with your correct code. 
  
#d. Find the average of the vector from part a.
# mean = 20.0

# built in function mean
answer1_d <- mean(vector1)         # TO DO: replace NULL with your correct code.
  
#e. Find the sample standard deviation of the vector from part a.

# built in function sd = standard deviation
answer1_e <-  sd(vector1)        # TO DO: replace NULL with your correct code.

#f. Create a vector of integer values from 1883 to 1883 + 30 with an increment of 2.
# 1883 is a single number: there is no multiplication between the letters (e.g. 0123 = 123).

# built in function sequence, seq and include steps by key "by"
vector_f = seq(1883, 1913, by = 2)

answer1_f <-  vector_f        # TO DO: replace NULL with your correct code.

#------ TASK 2 -------# [5 marks]   
# In a cafe, the customers arrive at a mean rate of (8+10=18) per every 10 minutes. The average number of customers per hour is (6*8 + 60 = 108).
# The variance of customer arrivals is equal to (8+10=18). Find the probability of arrival of at least (8+1=9) customers in 1 minute.
                    # You can add extra lines here if needed.

lmbd <- 18 / 10
# 9 - 1 because in need to include 9 as in the requirements indicated that it should be at leat 9 customers
atleast2 <- 9 - 1 
# to not confuse myself, I used =>  1 - with lower tail True (default) 
answer2 <- 1 - ppois(atleast2, lambda = lmbd)    # TO DO: replace NULL with your correct code.
  
#------ TASK 3 -------# [5 marks]
# Suppose that the marks of students from ISDS have bimodal distribution.
# The modes are given as 30 and 60, median is 42, mean is 45 and standard deviation is 25.
# If (36 + 1 + 8 = 45) students are randomly chosen, what is the probability that their 
# average mark is more than (40 + 8 + 3 = 51)?

# data
mean3 <- 45
sd3 <- 25

# a little bit confused with bimodal distribution, so I guess to use pnorm distribution 
# (official documentation did not help)
# to find info about bimodal distribution
answer3 <- 1 - pnorm(51, mean3, sd3/sqrt(mean3))   # TO DO: replace NULL with your correct code.

#------ TASK 4 -------# [5 marks]
# About (8+8 = 16)% of males are colorblind. A researcher needs three colorblind men for an experiment and begins checking potential subjects.
# What is the probability that she finds exactly 3 or 4 men in the first (3+5=8) trials she examines?
# The average number of colorblind men out of sample size of (3+5=8) is equal to (3+5)*(8+8)/100.

# data
size4 <- 8
prob4 <- 0.16
avg4 <- 1.28

# dbinom function to find exact 3 or 4 mens => F(x = k)
answer4 <-  dbinom(3, size4, prob4) + dbinom(4, size4, prob4)   # TO DO: replace NULL with your correct code.

#------ TASK 5 -------# [10 marks]

# Suppose, the closing price of Apple Inc. common stock is uniformly distributed
# between $(150+1=151) and $(250+8=258) per share. The mean price is (200 + (1 + 8)/2 = 204.5)
# a. What is the probability that the stock price will be at least $200?

# data
mean5_a <- 200 + 9/2
start5_a <- 151
end5_a <- 258
at_least5_a <- 200

# as it is uniformly distributed and I know all necessary values, therefore able to use 
# punif function with our data above
answer5_a <- 1 - punif(at_least5_a, start5_a, end5_a)   # TO DO: replace NULL with your correct code.

# b. Find the 75th percentile of the Apple stock price.

# data'
min5_b <- 151
max5_b <- 258
percent5_b <- 0.75

# to find percentile I used qunif (provided info from lectures to use) or without R => F(x = k) = (k - a) / (b - a) formula
# where k is the 0.75
answer5_b <- qunif(percent5_b, min = min5_b, max = max5_b)   # TO DO: replace NULL with your correct code.

#------- TASK 6 -------# [10 marks]

# Based on a random sample of movie lengths, the mean length is (100+1=101) minutes with a standard
# deviation of (20+8=28) minutes. Assume that movie lengths are normally distributed.

#a. What PERCENT of movies are more than 2 hours long? Do not include the percentage sign.

# data
mean6_a <- 101
sd6_a <- 28

# for normal distribution I use pnorm and multiply by 100 to get percent value (% sign did not included)
answer6_a <- (1 - pnorm(120, mean = mean6_a, sd = sd6_a))*100   # TO DO: replace NULL with your correct code.

#b. If you select (60+3=63) movies at random, what is the (90+8=98)th percentile for the average length? 

# To generate random values of 63 movies length I use rnorm, where I provided corresponding data
movies6_b <- rnorm(63, mean = mean6_a, sd = sd6_a)
mean6_b <- mean(movies6_b)
sd6_b <- sd(movies6_b)
answer6_b <- qnorm(0.98, mean = mean6_b, sd = sd6_b)   # TO DO: replace NULL with your correct code.

#------- TASK 7 -------# [15 marks]
# Import the "bank.csv" into your R Studio. This file is given in the Portfolio zip folder. 
# This data is related with direct marketing campaigns (phone calls) of a Portuguese banking institution.
# You can learn more about this dataset in the following link:
# http://archive.ics.uci.edu/ml/datasets/Bank+Marketing
# You can add extra lines of codes above the answer line if needed.

# First, set your working directory to the file path (do not include the setwd() code here. We will set it to our own directory when checking your code).
bank <- read.csv('bank.csv', sep=';') # To DO: read the csv file into R Studio. Hint: the separator is not comma (,), but semicolon (;)
                  # That means you need to use one more argument to properly import the dataset into R.
# Before answering the questions, DELETE the following rows from the dataset all at once: (1+100=101), (8+1000=1008), (8 + 2260=2268), (3 + 3100=3103)
# Hint: you can use the following syntax to delete rows: df <- df[-c(a, b, ...), ]
# thanks for the hint
bank <- bank[-c(101,1008,2268,3103), ]

#a. Count the number of unemployed individuals from this dataset.
# If the type of job is given as "unknown", consider them as employed.

# converted all character data type to factor as Module Leader recommended to do so

bank$job <- as.factor(bank$job)
bank$marital <- as.factor(bank$marital)
bank$education <- as.factor(bank$education)
bank$default <- as.factor(bank$default)
bank$housing <- as.factor(bank$housing)
bank$loan <- as.factor(bank$loan)
bank$contact <- as.factor(bank$contact)
bank$month <- as.factor(bank$month)
bank$poutcome <- as.factor(bank$poutcome)
bank$y <- as.factor(bank$y)

# check data types of each columns
str(bank)

# counting unemployed people
jobUnemployed = subset(bank, bank$job == 'unemployed')
countUnemployed = nrow(jobUnemployed)

answer7_a <- countUnemployed     # TO DO: replace NULL with your correct code.

# check answer from table with displaying the number by table built in function
table(bank$job)

#b. What PERCENT of clients who have at least secondary education have defaulted on their loans?
# Here total sample is those who have at least secondary education.

# If default is "unknown", consider it as NO default.
# If education is "unknown", consider it as primary education.
# Your answer code must provide a numeric value once it is run: don not include the percentage sign.'

# I use subset to take only needed data from a bank, secondary + tertiary, because in requirements said at least secondary education
# also default status to be 'yes', afterwards wrap with nrow() function to get success data which match required query.
# Then divide by amount of students and multiplying by 100 to get percentage value.

answer7_b <- nrow(subset(bank, bank$education == "secondary" | bank$education == 'tertiary' & bank$default == 'yes'))/nrow(subset(bank, bank$education == "secondary" | bank$education == 'tertiary')) * 100         # TO DO: replace NULL with your correct code.

#c. What is the average Credit Balance of single students? 

# we wrapp all by mean function and pass arguments with single marital status and student occupation, and take from the
# filtered data only balance, plus say to function to remove NA values
answer7_c <- mean(subset(bank, bank$marital == 'single' & bank$job == 'student')$balance, na.rm = T)      # TO DO: replace NULL with your correct code.

#d. Out of clients who are aged 30 or above, what percent of them are both married and work in management positions.
# If the job position is unknown, do not consider them in management position. Do not include the percentage sign.

# Firstly we allocate those people from all ( married + management + age(>=30) ), count the number of success data
# Then, divide by number of people whose age more or equal 30, the result will be also multiplied by 100 to get percent value

answer7_d <- nrow(subset(bank, bank$marital == 'married' & bank$job == 'management' & bank$age >=30 ))/nrow(subset(bank, bank$age >= 30)) * 100         # TO DO: replace NULL with your correct code.

#e. What is the median age of those clients who are married OR have at least secondary education?
# If education is "unknown", consider it as primary education.

# I will use built in function median and inside pass data
# Getting from bank, we need married status or education being at least secondary (so, secondary + tertiary)
# From that frame without leaving median function, we take only ages
# As a result, only ages data frame with required condition will be applied

answer7_e <- median(subset(bank, bank$marital == "married" | bank$education == 'secondary' | bank$education == 'tertiary')$age)         # TO DO: replace NULL with your correct code.

#------- TASK 8 -------# [10 marks]
# Let's import the Titanic data set, which is a famous data set involving passengers of Titanic Cruiseship.
titanic <- read.csv(url("https://web.stanford.edu/class/archive/cs/cs109/cs109.1166/stuff/titanic.csv"))
# Delete the following rows from the dataset before answering the questions: (1+1), (8+21), (8+121), (3+333)
titanic <- titanic[-c(2,29,129,336), ]
# You can learn more about each variable from the following link: https://www.kaggle.com/c/titanic/data
# by checking out the Data Library.
# You can add exra rows if needed above the answer line, but your code which provides the final answer must
# be provided in the provided answer lines.
# If NAs are present in the dataset, they should be removed before answering the questions.

#a Compute the standard deviation of fares for female survived passengers.

# I use built in function sd and provide query with survived women, and from them include their fare

answer8_a <- sd(subset(titanic, titanic$Sex == 'female' & titanic$Survived == T)$Fare) # TO DO: replace NULL with your correct code.

#b Calculate the average age of those passengers whose name (either first or last name) contains "William".
# All cases of "William" must be inñluded in the subset, such as "WILLIAM", "william" or "William".

# Use built in mean function and pass arguments with using another built in grepl function
# to find matches, additionally, by indicating ignore.case = T (TRUE), it will not be case sensitive and count any character case
# and the same as we did earlier, get from whole query result only age and inject it to mean function

answer8_b <- mean(subset(titanic, grepl("William", titanic$Name, ignore.case = T))$Age)    # TO DO: replace NULL with your correct code.

#------- TASK 9 -------# [10 marks]
# Suppose you entered a building where there are (500+1883) doors numbered from 1 to (500+1883). 
# Here, 1883 is just one number: there is no multiplication between the letters.
# At first, all of the doors are locked. (500+1883) students from WIUT are sent to change the state of the doors (from locked to unlocked or from unlocked to locked).
# The students act one after another, which means that second student starts after the first one, third student starts after the second one, etc.
# The first student unlocks all doors. The second student changes the state of every other door (2, 4, 6, ...).
# The third changes the state of every third door (3, 6, 9, ...). This process goes on until all (500+1883) students have completed according to the rule.
# Which door numbers are left unlocked after all students pass through the building?
# Write your R code to answer this question. Your final answer in the form of a VECTOR should be stored in the given "answer9" variable.
# Your answer vector must provide the values in ascending order (e.g. 1, 6, 10, etc.)
# TO DO: Write your code here. Hint: looping and sequencing


# doors counts with id and student from 1 to 2383
doors = c(1:2383)
# result will display only door numbers with unlocked state, at initial point is equal to NULL or just empty array (vector)
result <- c()

# Logic of the code
# as we have door numbers, we can find divisors of the door, and check the state
# for example, let's take door number 38
# divisor of 38 => 1 > 2 > 19 > 38 
# so 1 unlock -> 2 lock -> 19 unlock -> 38 lock
# let's take another one, door number = 49
# divisor of 49 => 1 > 7 > 49
# 1 unlock > 7 lock > 49 unlock

# if we look attentively, there is shown that even amount of divisor of a particular number, is locking at the end.
# and odd number divisors, change to unlocked state.
# also multiplication of corner numbers gives the door's number itself.

# to get an algorithm of this
# we can assume door index = to "Z", and it has several divisors => y1, y2, y3, y4, y5
# and from the previoãs judgement y1 * y5, y2 * y4, and y3 * y3 gives "Z"
# Hence we can conclude that perfect square number indexes leaves door in an unlocked state

# loop
for (i in doors) {
  # checking for perfect square status
  if (sqrt(i) %% 1 == 0) {
    # adding the truthful index to the array, that indicates unlocked door
    result <- append(result, i)
  }
}

answer9 <- result    # TO DO: replace NULL with correct vector of values

#------- TASK 10 -------# [5 marks]
set.seed(11883) # TO DO: replace ID with your student ID.
companies <- c("Kroger Co", "Cisco Systems", "WellsFargo & Co", "Bank of America Corp",
               "Norwegian Cruise Line Holdings Ltd", "Delta Air Lines Inc", "Pfizer Inc",
               "American Airlines Group Inc", "ConocoPhillips", "Oracle Corporation",
               "Verizon Communications", "AT&T Inc", "Apple Inc", "Walmart Inc")
rlist <- as.vector(sample(companies, 3))       # run these 4 lines of code ONLY ONCE to get random three company names.
cat("Your company list:", rlist, sep = "   ")  # this line of code prints the names of 3 companies that you must use for your plot.
# For this task, you need to randomly select 3 companies out of the company list provided above.
# Hint: you can use "quantmod" package to import stock price data from Yahoo Finance.
# Import the stock price data from Jan 2nd, (2000 + 1) to Jan 2nd (2010 + 8)
# Convert the daily stock data to Weekly data (only last trading day of each week will be stored) and plot a line graph showing all three stock prices in one plot.
# Use the column for Close Price in y axis of your graph and use three different colors for the lines.
# Use ylim option to make sure all 3 lines are visible in your plot for the whole period.
# Use legend option to place a legend on an empty spot of your graph.

# timescale assigning
start10 <- "2001-01-02"
ends10 <- "2018-01-02"
dataSource <- "yahoo"

# assign to variables data frames of companies in rlist 
# 1 - Apple Inc
# 2 - Bank of America Corp
# 3 - Walmart Inc

appleInc <- getSymbols("AAPL" , src = dataSource, from=start10, to = ends10, auto.assign = F) 
bankOfAmericaCorp <- getSymbols("BAC" , src = dataSource, from = start10, to = ends10, auto.assign = F) 
walmartInc <- getSymbols("AAL" , src = dataSource, from = start10, to = ends10, auto.assign = F)

# converting to data frame

appleInc <- as.data.frame(appleInc)
bankOfAmericaCorp <- as.data.frame(bankOfAmericaCorp)
walmartInc <- as.data.frame(walmartInc)

# Take only last day of week Close price as indicated in requirements
appleInc <- subset(appleInc, weekdays(as.Date(rownames(appleInc))) == "Friday")
bankOfAmericaCorp <- subset(bankOfAmericaCorp, weekdays(as.Date(rownames(bankOfAmericaCorp))) == "Friday")
walmartInc <- subset(walmartInc, weekdays(as.Date(rownames(walmartInc))) == "Friday")

# creating plots to use them in lines

plot(x = index(appleInc), y=appleInc[, 4], type='l', col='red', ylab='Price in USD', xlab="Timescale", ylim = c(0, 80))
plot(x = index(bankOfAmericaCorp), y=bankOfAmericaCorp[, 4], type='l', lty=2,  col='green', ylab='Price in USD', xlab="Timescale", ylim = c(0, 80))
plot(x = index(walmartInc), y=walmartInc[, 4], type='l', lty=3, col='purple', ylab='Price in USD', xlab="Timescale", ylim = c(0, 80))

# drawing lines and representing them in a one view (at one glance)

lines(x = index(appleInc) , y = appleInc[, 4], type= 'l', col = 'red')
lines(x = index(bankOfAmericaCorp) , y = bankOfAmericaCorp[, 4], type= 'l', lty = 2, col='green')
lines(x = index(walmartInc) , y = walmartInc[, 4], type= 'l', lty = 3, col='purple')

# adding legend on the top (enough free space only there or top right corner) 
# and specify colors of lines to which company it corresponds
legend(x = 'top', y = 'top', legend = c("Apple Inc", "Bank of America Corp", "Walmart Inc"), col = c('red', 'green', 'purple'), lty=1:3)

#------- TASK 11 -------# [10 marks]
# Create a function named "answer11", which takes a data frame as an argument. This data frame contains only x and y columns.
# Your function needs to provide a scatter plot of y (vertical axis) and x (horizontal axis).
# The point symbols of the graph must be asterisk (*) instead of circles and the colors are blue.
# If there are any data points which are greater or smaller by more than one standard deviation from the mean,
# then their colors must be red. (See the image provided in the Portfolio zip folder to have a complete idea of this task)
# Example 1. The following data frame is passed into your function:
# s1 <-  data.frame(y = c(1, 5, 2, 3, 4, 1), x = c(3, 50, 4, 6, 7, 10))
# The mean and standard deviations are as follows:
# mean_y = 2.67, sd_y = 1.63
# mean_x = 13.33,  sd_x = 18.13
# Then, if there is any point that is outside (2.67 +/- 1.63) = (1.04, 4.30) in y axis AND (13.33 +/- 18.13) = (-4.8, 31.46) in x axis, they should be colored red in the scatterplot.
# In this example, second observation (y = 5, x = 50) would be red. The remaining data points (asterisks to be more precise) would be blue.
# Example 2. The following data frame is passed into your function:
# s2 <-  data.frame(x = c(3,20, 25, 23, 4, 30), y = c(12, 15, 10, 13, 3, 25))
# The following points turn red: fifth (x = 4, y = 3) and sixth (x = 30, y = 25)
# The remaining points are colored blue.
# Now, complete the following function. Please note that your function should properly display any data frame with x, y, columns.


answer11 <- function(df) {
  # calculating average and standard deviation of x and y axis
  mean_x <- mean(df$x)
  mean_y <- mean(df$y)
  sd_x <- sd(df$x)
  sd_y <- sd(df$y)
  
  # assign to coordinates columns
  x <- df$x
  y <- df$y
  
  # determine the range of point to be blue
  lessX <- mean_x - sd_x
  outX <- mean_x + sd_x
  lessY <- mean_y - sd_y
  outY <- mean_y + sd_y
  
  # draw a plot with condition outlined in the requirements, shortly => out of the limit? => red, within ? => blue colour
  plot(x, y, xlab="X",ylab="Y", pch = 8, col = ifelse((x < lessX | x > outX) & (y < lessY | y > outY), 'red','blue'))
}

# using sample data provided for testing
s1 <-  data.frame(y = c(1, 5, 2, 3, 4, 1), x = c(3, 50, 4, 6, 7, 10))
# calling the function
answer11(s1)

# using sample data provided for testing
s2 <-  data.frame(x = c(3,20, 25, 23, 4, 30), y = c(12, 15, 10, 13, 3, 25))
# calling the function
answer11(s2)

# For task 12
# As there is not indicated with zeroes or without them, I decided to put with
# If it's incorrect, here I leave as a reference without them => 11883

#------- TASK 12 -------# [3 marks]
# Copy/Paste the following statement below in the quotation mark: 
# "I hereby confirm that this work is solely my own work and my id is ______. I am fully aware of the consequences of student misconduct."     TO DO: replace the blanks with your student ID.
answer12 <- "I hereby confirm that this work is solely my own work and my id is 00011883. I am fully aware of the consequences of student misconduct."        # TO DO: replace NULL with your correct code.
print(answer12)
#-------------------------------------------------------------- END OF TASKS --------------------------------------------------------------------------------#
#--------------------------------------------------------------- GOOD LUCK!----------------------------------------------------------------------------------#