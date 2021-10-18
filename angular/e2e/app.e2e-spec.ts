import { LifeTemplatePage } from './app.po';

describe('Life App', function() {
  let page: LifeTemplatePage;

  beforeEach(() => {
    page = new LifeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
