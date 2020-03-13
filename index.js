import { NativeModules, Platform } from "react-native";

const { RNSpeedTransformVideo } = NativeModules;

if (Platform.OS === "android") {
  module.exports = {
    slowMotion: function() {
      RNSpeedTransformVideo.slowMotion();
    }
  };
  module.exports = {
    timeLapse: function() {
      RNSpeedTransformVideo.timeLapse();
    }
  };
}

if (Platform.OS === "ios") {
  module.exports = {
    slowMotion: function() {
      RNSpeedTransformVideo.slowMotion();
    }
  };
  module.exports = {
    timeLapse: function() {
      RNSpeedTransformVideo.timeLapse();
    }
  };
}

export default RNSpeedTransformVideo;
