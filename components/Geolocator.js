import React, { useState } from 'react';
import {
  Text,
  View,
  Button,
  NativeModules
} from 'react-native';

const Geolocator = () => {

    const [location, setLocation] = useState('');

    const getCoordinates = async () => {
        var result = await NativeModules.GeolocationModule.getCoordinates();
        setLocation(result);
    }

    return(
        <View>
            <Button title="Get position" onPress={getCoordinates} />
            <Text>{location}</Text>
        </View>
    );
}

export default Geolocator;