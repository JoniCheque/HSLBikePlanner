import React, { useEffect, useState } from 'react';
import styles from './mapcomponent.module.css';
import maplibregl from 'maplibre-gl';
import Map, {Marker, NavigationControl} from 'react-map-gl';
import 'maplibre-gl/dist/maplibre-gl.css';

  function getStations(){
    return fetch('https://localhost:7030/Station/GetAllStations')
      .then(data => data.json())
  };

export interface MapcomponentProps {}

interface Station {
  lat: number;
  lon: number;
  name: string;
  stationId: number;
  stationStrId: string;
}

export function Mapcomponent(props: MapcomponentProps) {
  const [stationData, setStationData] = React.useState<Station[] | undefined>(undefined);

  useEffect(() => {
    fetch('https://localhost:7030/Station/GetAllStations')
    .then(response => response.json())
    .then((response) => {
      setStationData(response);
    });
    }, []);

  return (
    <div className={styles['container']}>
      <div className="App">
        <Map mapLib={maplibregl} 
          initialViewState={{
            longitude: 24.93178,
            latitude: 60.16556,
            zoom: 13
          }}
          style={{width: "100%", height: " calc(75vh - 90px)"}}
          mapStyle="https://api.maptiler.com/maps/streets/style.json?key=IrM0m1zv3WHy3SyZUfCR"
        >
          <NavigationControl position="top-left" />
          {stationData?.map(station => <Marker latitude={station.lat} longitude={station.lon} color="#d4d6d6" />)}
        </Map>
      </div>
    </div>
  );
}

export default Mapcomponent;
