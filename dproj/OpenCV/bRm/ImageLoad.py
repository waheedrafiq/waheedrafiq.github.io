# load picture
from PIL import Image
from pylab import *
import cv2

imgFile = cv2.imread('wr-pb.jpg',0)

cv2.imshow('dst_rt', imgFile)
cv2.waitKey(0)

cv2.destroyAllWindows()
