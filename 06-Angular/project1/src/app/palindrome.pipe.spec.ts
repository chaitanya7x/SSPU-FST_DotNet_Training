import { PalindromePipe } from './palindrome.pipe';

describe('PalindromePipe', () => {
  it('create an instance', () => {
    const pipe = new PalindromePipe();
    expect(pipe).toBeTruthy();
  });
});
