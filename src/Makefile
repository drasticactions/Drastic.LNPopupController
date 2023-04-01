XBUILD=/Applications/Xcode_14.2.0.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/LNPopupController.git
PROJECT_IOS=$(PROJECT_ROOT)/LNPopupController/LNPopupController.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
PROJECTNAME=LNPopupController
IOS_FRAMEWORK_PATH=Products/Library/Frameworks/LNPopupController.framework
FRAMEWORKS=$(ROOT)/Frameworks
TARGET_IOS="LNPopupController"
IOS_SDK=iphoneos16.2
BINDING_OUTPUT=$(ROOT)/../bindings
HEADERS=$(FRAMEWORKS)/$(PROJECTNAME).xcframework/ios-arm64/LNPopupController.framework/Headers

build: iossimulator iosdevice maccatalyst xcframework

iossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_IOS) -configuration Debug -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/simulator.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES
	
iosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_IOS) -configuration Debug -destination "generic/platform=iOS" -archivePath $(BUILD_ROOT)/iOS.xcarchive -sdk iphoneos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

maccatalyst:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_IOS) -destination "generic/platform=macOS,variant=Mac Catalyst,name=Any Mac" -archivePath $(BUILD_ROOT)/catalyst.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework:
	rm -rf $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/catalyst.xcarchive/$(IOS_FRAMEWORK_PATH) -framework $(BUILD_ROOT)/simulator.xcarchive/$(IOS_FRAMEWORK_PATH) -framework $(BUILD_ROOT)/iOS.xcarchive/$(IOS_FRAMEWORK_PATH) -output $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	cp -R $(BUILD_ROOT)/ $(FRAMEWORKS)

pack: 
	dotnet pack $(ROOT)/Drastic.LNPopupController/Drastic.LNPopupController.csproj --configuration Release --output $(ROOT)/../nuget

sharpie:
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_OUTPUT)" --namespace="LNPopupController" --scope="$(HEADERS)" $(HEADERS)/*.h