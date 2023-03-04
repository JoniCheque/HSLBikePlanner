import styles from './favourite.module.css';

/* eslint-disable-next-line */
export interface FavouriteProps {}

export function Favourite(props: FavouriteProps) {
  return (
    <div className={styles['container']}>
      <h1>Welcome to Favourite!</h1>
    </div>
  );
}

export default Favourite;
