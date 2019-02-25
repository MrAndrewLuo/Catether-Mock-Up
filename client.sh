# Writer to bluetooth serial connection

sudo rfcomm connect hci0 D0:A6:37:EB:B6:74 &> /dev/null &
echo "Writing to /dev/rfcomm0"
