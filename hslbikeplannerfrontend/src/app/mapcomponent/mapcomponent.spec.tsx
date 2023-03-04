import { render } from '@testing-library/react';

import Mapcomponent from './mapcomponent';

describe('Mapcomponent', () => {
  it('should render successfully', () => {
    const { baseElement } = render(<Mapcomponent />);
    expect(baseElement).toBeTruthy();
  });
});
