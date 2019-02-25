# Reader to bluetooth serial connection

sudo rfcomm watch hci0 &> /dev/null &
echo "Starting server, listening on /dev/rfcomm0"
