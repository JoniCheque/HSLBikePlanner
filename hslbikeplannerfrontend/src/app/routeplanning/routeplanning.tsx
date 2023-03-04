import styles from './routeplanning.module.css';

/* eslint-disable-next-line */
export interface RouteplanningProps {}

export function Routeplanning(props: RouteplanningProps) {
  return (
    <div className={styles['container']}>
      <h1>Welcome to Routeplanning!</h1>
    </div>
  );
}

export default Routeplanning;
