# faceDetectPhoto.py
#Author: Waheed Rafiq
#Research Student Birmingham City University
#Date: 18/03/2017
#Description : Detect Face in a image meansure with distance[manually]
# Should you wish to use this code for education purpose
# in your assignment or dessertation
# please use the correct citation and give credit to the Author / University

#Import library required for Capture face.
import numpy as np
import cv2
from matplotlib import pyplot as plt

face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')

#read image path 
img = cv2.imread('Photos-XploR/indoor/Sub1_10_indoor.png')

gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

faces = face_cascade.detectMultiScale(gray, 1.3, 5)


for (x,y,w,h) in faces:
    cv2.rectangle(img,(x,y),(x+w,y+h),(255,0,0),2)
    roi_gray = gray[y:y+h, x:x+w]
    roi_color = img[y:y+h, x:x+w]
    
# out put the  rectangle drawn on the image
cv2.namedWindow('Birmingham City University : RD By Waheed Rafiq ',cv2.WINDOW_NORMAL)
cv2.imshow('Birmingham City University : RD By Waheed Rafiq ',img)

cv2.waitKey(0)
cv2.destroyAllWindows()
