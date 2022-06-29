import { TestBed } from '@angular/core/testing';

import { TidsregService } from './tidsreg.service';

describe('TidsregService', () => {
  let service: TidsregService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TidsregService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
