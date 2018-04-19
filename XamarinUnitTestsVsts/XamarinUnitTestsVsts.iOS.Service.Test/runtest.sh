#!/bin/sh
echo 'Output path = ' $1
echo 'Root Directory = ' $2
TEST_RESULT=$1/test_results.xml
ROOT_DIRECTORY=$2
echo 'Delete test result'
rm -rf $TEST_RESULT
mono --debug $ROOT_DIRECTORY/XamarinUnitTestsVsts/XamarinUnitTestsVsts.iOS.Service.Test/Touch.Server.exe \
--launchsim  \
-autoexit \
-skipheader \
-logfile=$TEST_RESULT \
--verbose \
--device=":v2:runtime=com.apple.CoreSimulator.SimRuntime.iOS-11-2,devicetype=com.apple.CoreSimulator.SimDeviceType.iPhone-SE"
