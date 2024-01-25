import { TestBed } from '@angular/core/testing';

import { UtilizatorServiceService } from './utilizator-service.service';

describe('UtilizatorServiceService', () => {
  let service: UtilizatorServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UtilizatorServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
