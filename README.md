# Paced Auditory Serial Addition Test (PASAT)
[PASAT](https://www.nationalmssociety.org/For-Professionals/Researchers/Resources-for-Researchers/Clinical-Study-Measures/Paced-Auditory-Serial-Addition-Test-(PASAT)) is a cognitive assessment test developed in 1977 by Gronwell. It is made up of a sequence of single digit numbers that are given to a patient in a predefined interval. The patient must add each number to the number immediately prior to it and report the results. The examiner will record the correctness of the results and the response time. These values will later be used to assess the auditory information processing speed. This software performs both PASAT and [PVSAT](https://www.ncbi.nlm.nih.gov/pubmed/11125707).

Software has one main window that is accessible to the examiner. Through this window examiner can configure the exam by using options such as: language for the numbers, sensitivity to the vocal response of the examinee and time interval length. They can also decide to conduct PASAT, PVSAT or both. If PVSAT is used for the experiment, the second window is shown to the patient.

![Main Windows](/screenshots/main_window.PNG)

The exam procedure is as below:
1) The software announced a number.
2) The patient must add that number to the previous one and announce it in the given time limit.
3) When the patient’s voice goes beyond the sensitivity threshold, software pauses the test waiting for the examiner to mark it as correct or false.

There is an option for automatic query, which automatically plays the next number when it captures user's response. Still, the examiner has the capability to change the correctness of each answer during the test.

![Exam procedure](/screenshots/exam.PNG)

Finally, the software opens a window to save the results in two formats: txt and xls.

![Output](/screenshots/output.PNG)
