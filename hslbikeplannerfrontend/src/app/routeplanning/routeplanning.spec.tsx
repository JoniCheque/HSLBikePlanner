import { render } from '@testing-library/react';

import Routeplanning from './routeplanning';

describe('Routeplanning', () => {
  it('should render successfully', () => {
    const { baseElement } = render(<Routeplanning />);
    expect(baseElement).toBeTruthy();
  });
});
