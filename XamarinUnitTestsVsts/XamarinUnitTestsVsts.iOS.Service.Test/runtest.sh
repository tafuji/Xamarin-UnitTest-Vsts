#!/bin/sh
echo 'Output path = ' $1
echo $NUNIT_ENABLE_XML_OUTPUT
ROOT_DIRECTORY=$1
TEST_PROJECT_DIRECTORY=$1/$2
TEST_RESULT=$TEST_PROJECT_DIRECTORY/test_results.xml
echo 'Delete test result'
rm -rf $TEST_RESULT
mono --debug $TEST_PROJECT_DIRECTORY/Touch.Server.exe \
--launchsim  ./bin/iPhoneSimulator/Debug/XamarinUnitTestsVsts.iOS.Service.Test.app \
-autoexit \
-skipheader=$NUNIT_SKIP_LOG_HEADER \
-logfile=$TEST_RESULT \
--verbose \
--device=":v2:runtime=com.apple.CoreSimulator.SimRuntime.iOS-11-3,devicetype=com.apple.CoreSimulator.SimDeviceType.iPhone-8"
