echo 'activity=' %1
echo 'TestToolPath = ' %2
echo  'adbpath=' = %3
set TEST_RESULT=%2/test_results.xml

%2/Touch.Server.Android.exe --autoexit --activity=%1 --logfile=%TEST_RESULT% --adbpath=%3
