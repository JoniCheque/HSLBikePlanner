import React, { useEffect, useState, useRef } from 'react';
import styles from './mapcomponent.module.css';
import maplibregl from 'maplibre-gl';
import Map, {Marker, NavigationControl} from 'react-map-gl';
import 'maplibre-gl/dist/maplibre-gl.css';
import Overlay from 'react-bootstrap/Overlay';
import Tooltip from 'react-bootstrap/Tooltip';


export interface MapcomponentProps {}

interface Station {
  lat: number;
  lon: number;
  name: string;
  stationId: number;
  stationStrId: string;
}

interface BicycleDataEntry {
  stationId: number;
  stationStrId: string,
  longestDistance: number,
  shortestDistance: number,
  longestDuration: number,
  shortestDuration: number,
  lat: number,
  lon: number,
  stationName: string
}

export function Mapcomponent(props: MapcomponentProps) {
  const [stationData, setStationData] = React.useState<Station[] | undefined>(undefined);
  const [show, setShow] = useState(false);
  const [selectedStationId, setSelectedStationId] = useState("");
  const [selectedStation, setSelectedStation] = useState<BicycleDataEntry | undefined>(undefined);
  const target = useRef(null)

  useEffect(() => {
    fetch('https://localhost:7030/Station/GetAllStations')
    .then(response => response.json())
    .then((response) => {
      setStationData(response);
    });
    }, []);


    function handleOnClick(stationId: string)
    {
      setShow(!show);
      setSelectedStationId(stationId);
      getStationInformation();
    }

    function getStationInformation()
    {
      fetch(`https://localhost:7030/Station/GetStationInformation?stationStrId=` + selectedStationId)
        .then(response => response.json())
        .then((response) => {
          setSelectedStation(response);
        });
    }

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
              {stationData?.map(station => <Marker onClick={() => handleOnClick(station.stationStrId)} latitude={station.lat} longitude={station.lon} color="#d4d6d6" />)}
              <Overlay target={target.current} show={show} placement="bottom">
                {(props) => (
                  <Tooltip id="overlay-example" {...props}>
                    Nimi: {selectedStation?.stationName}<br/>
                    Lat: {selectedStation?.lat}<br/>
                    Lon: {selectedStation?.lon}<br/>
                    Lyhyin aika: {selectedStation?.shortestDuration}s<br/>
                    Lyhyin matka: {selectedStation?.shortestDistance}m<br/>
                    Pisin aika: {selectedStation?.longestDuration}s<br/>
                    Pisin matka: {selectedStation?.longestDistance}m<br/>
                  </Tooltip>
                )}
              </Overlay>
          </Map>
        </div>
      </div>
    );
  }
export default Mapcomponent;
