import React from 'react';
import styles from './mapcomponent.module.css';
import maplibregl from 'maplibre-gl';
import Map, {NavigationControl, Marker} from 'react-map-gl';
import 'maplibre-gl/dist/maplibre-gl.css';

/* eslint-disable-next-line */
export interface MapcomponentProps {}

export function Mapcomponent(props: MapcomponentProps) {
  function handleSubmit()
  {
    console.log("dasdasd");
  }
  
  return (
    <div className={styles['container']}>
      <h5>Welcome to Map!</h5>
      <div className="App">
        <Map mapLib={maplibregl} 
          initialViewState={{
            longitude: 24.93178,
            latitude: 60.16556,
            zoom: 13,
            pitch: 25
          }}
          //style={{width: "100%", height: " calc(100vh - 90px)"}}
          style={{width: "100%", height: " calc(75vh - 90px)"}}
          mapStyle="https://api.maptiler.com/maps/streets/style.json?key=IrM0m1zv3WHy3SyZUfCR"
        >
          <NavigationControl position="top-left" />
          <Marker
            latitude={60.15555}
            longitude={24.93222}
            onClick={handleSubmit}
            color='#434343'/>
        </Map>
      </div>
    </div>
  );
}

export default Mapcomponent;
