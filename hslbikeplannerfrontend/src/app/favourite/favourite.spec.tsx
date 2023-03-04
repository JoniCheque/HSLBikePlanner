import { render } from '@testing-library/react';

import Favourite from './favourite';

describe('Favourite', () => {
  it('should render successfully', () => {
    const { baseElement } = render(<Favourite />);
    expect(baseElement).toBeTruthy();
  });
});
